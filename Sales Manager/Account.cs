using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sales_Manager
{
    public class Account
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string APIKey { get; set; }

        public void Add()
        {
            using (var db = new SalesManagerContext())
            {
                db.Accounts.Add(this);
                db.SaveChanges();
            }
        }

        public void Edit()
        {
            using (var db = new SalesManagerContext())
            {
                db.Accounts.Update(this);
                db.SaveChanges();
            }
        }

        public void Remove()
        {
            using (var db = new SalesManagerContext())
            {
                db.Transactions.RemoveRange(db.Transactions.Include(transaction => transaction.Account).Where(transaction => transaction.Account.ID.Equals(ID)));
                db.Products.RemoveRange(db.Products.Include(product => product.Account).Where(product => product.Account.ID.Equals(ID)));
                db.SaveChanges();
            }
            using (var db = new SalesManagerContext())
            {
                db.Accounts.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
