using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace Sales_Manager
{
    public class Transaction
    {
        [Key]
        public int ID { get; set; }

        public string OrderID { get; set; }

        public Country Country { get; set; }

        public Product Product { get; set; }

        public Account Account { get; set; }

        public double Price { get; set; }

        public double ReceivedAmount { get; set; }

        public double PartnerShare { get; set; }

        public double SupportAmount { get; set; }

        public double PriceAfterBuyerFee { get; set; }

        public double PriceAfterAuthorFee { get; set; }
        
        public double Tax { get; set; }

        public DateTime Date { get; set; }

        public string Detail { get; set; }

        public void Add()
        {
            using (var db = new SalesManagerContext())
            {
                Product = db.Products.First(item => item.ID.Equals(Product.ID));
                Country = db.Countries.First(item => item.ID.Equals(Country.ID));
                Account = db.Accounts.First(item => item.ID.Equals(Account.ID));
                GetPartnerShare();
                db.Transactions.Add(this);
                db.SaveChanges();
            }
        }

        public void Edit()
        {
            using (var db = new SalesManagerContext())
            {
                db.Transactions.Update(this);
                db.SaveChanges();
            }
        }

        public void Remove()
        {
            using (var db = new SalesManagerContext())
            {
                db.Transactions.Remove(this);
                db.SaveChanges();
            }
        }

        private void GetPartnerShare()
        {
            Price = Product.Price;
            if (PriceAfterBuyerFee.Equals(0))
            {
                PriceAfterBuyerFee = Product.Price - Product.BuyerFee;
            }
            if (PriceAfterAuthorFee.Equals(0))
            {
                PriceAfterAuthorFee = PriceAfterBuyerFee - PriceAfterBuyerFee * Product.AuthorFee;
            }
            if (Tax.Equals(0))
            {
                Tax = PriceAfterBuyerFee * Country.Tax;
            }
            if (ReceivedAmount.Equals(0))
            {
                ReceivedAmount = PriceAfterAuthorFee - Tax;
            }
            if (Product.PartnerShare > 0)
            {
                PartnerShare = ReceivedAmount * Product.PartnerShare;
                ReceivedAmount = ReceivedAmount - PartnerShare;
            }
        }

        public static bool GetSales(DateTime fromDate, DateTime toDate, Account account, BackgroundWorker backgroundWorker)
        {
            List<Transaction> transactions = new List<Transaction>();
            JArray jOrderInfoArray = new JArray();
            var i = 0;
            while (true)
            {
                try
                {
                    i++;
                    var response =
                        EnvatoAPIRequest(
                            $"https://api.envato.com/v3/market/user/statement?page={i}&from_date={fromDate:yyyy-MM-dd}&to_date={toDate:yyyy-MM-dd}", account);
                    var responseStream = response?.GetResponseStream();
                    if (responseStream != null)
                    {
                        using (var streamReader = new StreamReader(responseStream))
                        {
                            var orderInfoJson = streamReader.ReadToEnd();
                            var tempJArray = JArray.Parse(orderInfoJson);
                            jOrderInfoArray.Merge(tempJArray);
                            if (tempJArray.Count.Equals(0))
                            {
                                break;
                            }
                        }
                    }
                }
                catch (WebException)
                {
                    return false;
                }
            }
            int progress = 0;
            backgroundWorker.ReportProgress(progress, 1);
            using (var db = new SalesManagerContext())
            {
                for (var count = 0; count < jOrderInfoArray.Count; count++)
                {
                    var jToken = jOrderInfoArray[count];
                    var type = jToken["type"].ToString();
                    if (type.Equals("Withdrawal Request") || type.Equals("Skrill Fee") ||
                        type.Equals("Withdrawal Cancellation") || type.Equals("Skrill Fee Reversal") ||
                        type.Equals("Purchase") || type.Equals("Agreement Change") || type.Equals("Manual Adjustment") || type.Equals("Withdrawal Rejection"))
                    {
                        backgroundWorker.ReportProgress(count + 1, jOrderInfoArray.Count, 1);
                        continue;
                    }
                    var transaction = new Transaction
                    {
                        OrderID = jToken["order_id"].ToString(),
                        ReceivedAmount = 0,
                        Date = ((DateTimeOffset)jToken["date"]).DateTime,
                        Account = db.Accounts.First(ac => ac.ID.Equals(account.ID))
                    };
                    var detail = jToken["detail"].ToString();
                    if (type.Equals("Referral Cut"))
                    {
                        transaction.Detail = detail;
                        transaction.ReceivedAmount = (double)jToken["amount"];
                        if (
                            db.Transactions.Any(
                                tr =>
                                    tr.Product.ID.Equals(2) && tr.Date.Equals(transaction.Date) &&
                                    tr.ReceivedAmount.Equals(transaction.ReceivedAmount) &&
                                    tr.Detail.Equals(transaction.Detail)))
                        {
                            backgroundWorker.ReportProgress(count + 1, jOrderInfoArray.Count, 1);
                            continue;
                        }
                        transaction.Product = db.Products.First(product => product.ID.Equals(2));
                        transaction.Country = db.Countries.First(country => country.ID.Equals(1));
                        transaction.PartnerShare = 0;
                        db.Transactions.Add(transaction);
                        db.SaveChanges();
                        backgroundWorker.ReportProgress(count + 1, jOrderInfoArray.Count, 1);
                        continue;
                    }
                    int itemID = Convert.ToInt32(jToken["item_id"]);
                    transaction.Product = db.Products.FirstOrDefault(product => product.ID.Equals(itemID));
                    if (transaction.Product == null)
                    {
                        var newProduct = new Product
                        {
                            ID = itemID,
                            Account = account
                        };
                        db.Products.Add(newProduct);
                        db.SaveChanges();
                        transaction.Product = newProduct;
                    }
                    var tempTransaction =
                        transactions.FirstOrDefault(
                            tr =>
                                tr.OrderID.Equals(transaction.OrderID) && tr.Date.Equals(transaction.Date) &&
                                tr.Product.ID.Equals(transaction.Product.ID));
                    if (tempTransaction != null)
                    {
                        transaction = tempTransaction;
                    }
                    else
                    {
                        if (db.Transactions.Include(tr => tr.Product).Any(
                            tr =>
                                tr.OrderID.Equals(transaction.OrderID) &&
                                tr.Date.Equals(transaction.Date) && tr.Product.ID.Equals(transaction.Product.ID)))
                        {
                            backgroundWorker.ReportProgress(count + 1, jOrderInfoArray.Count, 1);
                            continue;
                        }
                        transactions.Add(transaction);
                    }
                    if (!type.Equals("Author Fee"))
                    {
                        if (string.IsNullOrEmpty(transaction.Detail))
                        {
                            transaction.Detail = detail;
                        }
                        else
                        {
                            if (detail.Contains("("))
                            {
                                var index = detail.LastIndexOf("(", StringComparison.InvariantCulture);
                                transaction.Detail += $" {detail.Substring(index)}";
                            }
                        }
                        if (transaction.Country == null)
                        {
                            if (string.IsNullOrEmpty(transaction.Product.Name))
                            {
                                transaction.Product.Name = detail.Split('(')[0].Replace("Reversal of", "").Replace("Refund for", "").Trim();
                                db.Products.Update(transaction.Product);
                                db.SaveChanges();
                            }
                            var orderCountry = jToken["other_party_country"].ToString();
                            transaction.Country =
                                db.Countries.FirstOrDefault(country => country.Name.Equals(orderCountry));
                            if (transaction.Country == null)
                            {
                                var countryObject = new Country
                                {
                                    Name = orderCountry,
                                    Tax = 0
                                };
                                db.Countries.Add(countryObject);
                                db.SaveChanges();
                                transaction.Country = countryObject;
                            }
                        }
                    }
                    if (detail.Contains("extended support") || detail.Contains("support extension"))
                    {
                        transaction.SupportAmount += (double)jToken["amount"];
                        backgroundWorker.ReportProgress(count + 1, jOrderInfoArray.Count, 1);
                        continue;
                    }
                    if (jToken["us_rwt"].Type != JTokenType.Null)
                    {
                        transaction.Tax += (double)jToken["us_rwt"];
                    }
                    if (type.Equals("Author Fee") || type.Equals("Author Fee Refund") || type.Equals("Author Fee Reversal"))
                    {
                        transaction.PriceAfterAuthorFee += Math.Abs((double)jToken["amount"]);
                    }
                    else
                    {
                        transaction.PriceAfterBuyerFee += (double)jToken["price"];
                    }
                    transaction.ReceivedAmount += (double)jToken["amount"];
                    backgroundWorker.ReportProgress(count + 1, jOrderInfoArray.Count, 1);
                }
                foreach (var transaction in transactions)
                {
                    if (transaction.Detail.ToLower().Contains("extended support") && !transaction.Detail.ToLower().Contains("included support"))
                    {
                        db.Transactions.Add(transaction);
                        continue;
                    }
                    transaction.PriceAfterAuthorFee = transaction.PriceAfterBuyerFee -
                                                      transaction.PriceAfterAuthorFee;
                    transaction.GetPartnerShare();
                    if (transaction.ReceivedAmount < 0)
                    {
                        var refundedTransaction =
                            db.Transactions.FirstOrDefault(
                                tr => tr.OrderID.Equals(transaction.OrderID) &&
                                      tr.Product.ID.Equals(transaction.Product.ID) &&
                                      tr.PriceAfterAuthorFee.Equals(transaction.PriceAfterAuthorFee)) ??
                            transactions.FirstOrDefault(
                                tr => tr.OrderID.Equals(transaction.OrderID) &&
                                      tr.Product.ID.Equals(transaction.Product.ID) &&
                                      tr.PriceAfterAuthorFee.Equals(transaction.PriceAfterAuthorFee));
                        if (refundedTransaction != null)
                        {
                            transaction.ReceivedAmount = refundedTransaction.ReceivedAmount * -1;
                            transaction.PartnerShare = refundedTransaction.PartnerShare * -1;
                            transaction.Detail += $" (Original Order was from {refundedTransaction.Date.ToShortDateString()})";
                        }
                    }
                    db.Transactions.Add(transaction);
                }
                db.SaveChanges();
            }
            return true;
        }

        private static WebResponse EnvatoAPIRequest(string url, Account account)
        {
            HttpWebRequest request =
                (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "application/json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0";
            request.ContentLength = 0;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("Authorization", $"Bearer {account.APIKey}");

            return request.GetResponse();
        }
    }
}