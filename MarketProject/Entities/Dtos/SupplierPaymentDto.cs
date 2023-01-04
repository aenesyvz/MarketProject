using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Dtos
{
    public class SupplierPaymentDto : IDto
    {
        public string SupplierFirstName { get; set; }
        public string SupplierLastName { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public int DebtSupplierId { get; set; }
        public decimal Payment { get; set; }
        public DateTime AddedPayment { get; set; }
    }
}
