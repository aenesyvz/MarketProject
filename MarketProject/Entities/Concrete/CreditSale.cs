using MarketProject.Core.Entities;

namespace MarketProject.Entities.Concrete
{
    public class CreditSale : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SaleId { get; set; }
        public int DebtCustomerId { get; set; }
    }
}
