using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Dtos
{
    public class CreditSaleDto : IDto
    {
        //public int Id { get; set; }
        public int ProdutctId { get; set; }
        public int CustomerId { get; set; }
        public int SaleId { get; set; }
        public int DebtCustomerId { get; set; }
        public DateTime DebtDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Code { get; set; }
        public string BarcodeNo { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
