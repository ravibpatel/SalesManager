using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sales_Manager
{
    public class Country
    {
        [Key, ForeignKey("Transaction")]
        public int ID { get; set; }

        public string Name { get; set; }

        public double Tax { get; set; }

        public void Add()
        {
            using (var db = new SalesManagerContext())
            {
                db.Countries.Add(this);
                db.SaveChanges();
            }
        }

        public void Edit()
        {
            using (var db = new SalesManagerContext())
            {
                db.Countries.Update(this);
                db.SaveChanges();
            }
        }

        public void Remove()
        {
            using (var db = new SalesManagerContext())
            {
                db.Transactions.RemoveRange(db.Transactions.Include(transaction => transaction.Country).Where(transaction => transaction.Country.ID.Equals(ID)));
                db.SaveChanges();
            }
            using (var db = new SalesManagerContext())
            {
                db.Countries.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
