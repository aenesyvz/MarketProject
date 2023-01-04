using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Concrete
{
    public class Waybill : IEntity
    {
        public int Id { get; set; }
        public int WaybillId { get; set; }
        //public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        //public string Barcode { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public int SupplierId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
