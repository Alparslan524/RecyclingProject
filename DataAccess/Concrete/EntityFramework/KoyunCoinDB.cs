using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class KoyunCoinDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MONSTERT7;Database=KoyunCoinDB;Trusted_Connection=true");
        }

        public DbSet<CarbonToKYC> CarbonToKYC { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Garbage> Garbages { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonType> PersonType { get; set; }
        public DbSet<SHA256> SHA256 { get; set; }

    }
}
