using MarketProject.Core.Entities;
using System;

namespace MarketProject.Entities.Concrete
{
    public class Supplier : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AddedTime { get; set; }
    }
}
