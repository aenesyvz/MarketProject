using MarketProject.Core.Entities;

namespace MarketProject.Entities.Dtos
{
    public class SupplierTotalDebtDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public float AmountOfDebt { get; set; }
        public float AmountPaid { get; set; }
        public float RemaingDebt { get; set; }
    }
}
