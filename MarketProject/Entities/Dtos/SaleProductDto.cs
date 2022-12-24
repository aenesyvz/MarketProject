using MarketProject.Core.Entities;

namespace MarketProject.Entities.Dtos
{
    public class SaleProductDto:IDto
    {
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string BarcodeNo { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
    }
}
