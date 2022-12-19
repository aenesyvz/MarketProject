using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Concrete
{
    public class Sale : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        //public int CustomerId { get; set; }
        //public int DebtCustomerId { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
