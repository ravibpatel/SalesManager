using System;
using System.IO;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Sales_Manager
{
    internal class SalesManagerContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RBSoft",
                "Sales Manager");
            Directory.CreateDirectory(databasePath);
            var connectionStringBuilder =
                new SqliteConnectionStringBuilder {DataSource = Path.Combine(databasePath, "database.smdb")};
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}
