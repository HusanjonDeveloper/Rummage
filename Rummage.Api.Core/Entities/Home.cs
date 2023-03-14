using Rummage.Api.Core.Entities.Enums;

namespace Rummage.Api.Core.Entities
{
    public class Home
    {
        public Guid Id { get; set; }
        public string Adress { get; set; }
        public string AdditionalInfo { get; set; }
        public bool IsVacant { get; set; }
        public int NumberOfBedRooms { get; set; }
        public int NumberOfBathRooms { get; set; }
        public double Area { get; set; }
        public bool IsPetAllowed { get; set; }
        public HomeType HomeType { get; set; }
        public decimal Price { get; set; }
        public  bool IsShared { get; set; }
        
        // Relations
        public Guid HostId { get; set; }
    }
}
