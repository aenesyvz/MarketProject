using MarketProject.Core.Entities;

namespace MarketProject.Entities.Concrete
{
    public class Product : IEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int WayBillId { get; set; }
        public string Code { get; set; }
        public string BarcodeNo { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal UnitOfPrice { get; set; }
    }
}
