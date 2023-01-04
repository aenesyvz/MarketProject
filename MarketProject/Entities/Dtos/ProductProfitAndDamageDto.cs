using MarketProject.Core.Entities;

namespace MarketProject.Entities.Dtos
{
    public class ProductProfitAndDamageDto : IDto
    {
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public decimal Result { get; set; }
    }
}
