using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sales_Manager
{
    public class Product
    {
        [Key, ForeignKey("Transaction")]
        public int ID { get; set; }

        public Account Account { get; set; }

        public string Name { get; set; }

        public double BuyerFee { get; set; }

        public double AuthorFee { get; set; }

        public double Price { get; set; }

        public double PartnerShare { get; set; }

        public string PartnerName { get; set; }

        public void Add()
        {
            using (var db = new SalesManagerContext())
            {
                Account = db.Accounts.First(item => item.ID.Equals(Account.ID));
                db.Products.Add(this);
                db.SaveChanges();
            }
        }

        public void Edit()
        {
            using (var db = new SalesManagerContext())
            {
                db.Products.Update(this);
                db.SaveChanges();
            }
        }

        public void Remove()
        {
            using (var db = new SalesManagerContext())
            {
                db.Transactions.RemoveRange(db.Transactions.Include(transaction => transaction.Product).Where(transaction => transaction.Product.ID.Equals(ID)));
                db.SaveChanges();
            }
            using (var db = new SalesManagerContext())
            {
                db.Products.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
