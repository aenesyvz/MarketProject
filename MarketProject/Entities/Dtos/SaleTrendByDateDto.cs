using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Dtos
{
    public class SaleTrendByDateDto : IDto
    {
        public DateTime SaleDate { get; set; }
        public int Sum { get; set; }
    }
}
