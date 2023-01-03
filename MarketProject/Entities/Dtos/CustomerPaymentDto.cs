using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Dtos
{
    public class CustomerPaymentDto : IDto
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int DebtCustomerId { get; set; }
        public decimal Payment { get; set; }
        public DateTime AddedPayment { get; set; }
    }
}
