﻿using Core.Entities.Concrete;
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
        public DbSet<SHA256> SHA256 { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
