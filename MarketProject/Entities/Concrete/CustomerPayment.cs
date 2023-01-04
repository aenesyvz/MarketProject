using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Concrete
{
    public class CustomerPayment : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DebtCustomerId { get; set; }
        public decimal Payment { get; set; }
        public DateTime AddedPayment { get; set; }
    }
}
