using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Concrete
{
    public class DebtSupplier : IEntity
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public DateTime AddedDate { get; set; }
        public float AmountOfDebt { get; set; }
        public float AmountPaid { get; set; }
        public float RemaingDebt { get; set; }
    }
}
