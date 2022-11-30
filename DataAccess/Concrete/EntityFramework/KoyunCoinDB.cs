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

        public DbSet<Garbage> Garbages { get; set; }
        public DbSet<Person> Persons { get; set; }
        
    }
}
