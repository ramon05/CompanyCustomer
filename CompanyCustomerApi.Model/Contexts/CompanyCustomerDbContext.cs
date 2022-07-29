using CompanyCustomerApi.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Contexts
{
    public class CompanyCustomerDbContext : BaseDbContext
    {
        public CompanyCustomerDbContext(DbContextOptions<CompanyCustomerDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
