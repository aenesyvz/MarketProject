using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Concrete
{
    public class DebtCustomer : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        //public int ProductId { get; set; }
        public DateTime AddedDate { get; set; }
        public decimal AmountOfDebt { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RemaingDebt { get; set; }
    }
}
