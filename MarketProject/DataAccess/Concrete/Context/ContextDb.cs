using MarketProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.DataAccess.Concrete.Context
{
    public class ContextDb:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<DebtCustomer> DebtCustomers { get; set; }
        public DbSet<Waybill> Waybills { get; set; }
        public DbSet<DebtSupplier> DebtSuppliers { get; set; }
        public DbSet<CreditSale> CreditSales { get; set; }
        public DbSet<CustomerPayment> CustomerPayments { get; set; }
        public DbSet<SupplierPayment> SupplierPayments { get; set; }

    }
}
