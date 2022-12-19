using MarketProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.Entities.Dtos
{
    public class CustomerTotalDebtDto:IDto
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal AmountOfDebt { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RemaingDebt { get; set; }
    }
}
