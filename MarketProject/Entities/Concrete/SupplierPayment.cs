using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Concrete
{
    public class SupplierPayment : IEntity
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int DebtSupplierId { get; set; }
        public decimal Payment { get; set; }
        public DateTime AddedPayment { get; set; }
    }
}
