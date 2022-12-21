using MarketProject.Core.Entities;
using System;

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
    public class SaleTrendByDateDto : IDto
    {
        public DateTime SaleDate { get; set; }
        public int Sum { get; set; }
    }
}
