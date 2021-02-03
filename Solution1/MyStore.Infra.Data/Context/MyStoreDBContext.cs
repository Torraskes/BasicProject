using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Infra.Data.Context
{
    public class MyStoreDBContext : DbContext
    {
        public MyStoreDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
