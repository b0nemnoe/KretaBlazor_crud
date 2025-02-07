
using Kreta.Shared.Models.SchoolCitizens;
using System.Drawing;

namespace Kreta.Shared.Models
{
    public class Address : IDbEntity<Address>
    {
        public Address()
        {
            Id = Guid.Empty;
            City = string.Empty;
            PublicSpaceName = string.Empty;
            House = -1;
            Floor = -1;
            Door = -1;
            PostalCode = -1;
            PublicScapeID = Guid.Empty;
        }
        public Address(Guid id, string city, string publicSpaceName, int house, int floor, int door, int postalCode, Guid publicScapeID)
        {
            Id = id;
            City = city;
            PublicSpaceName = publicSpaceName;
            House = house;
            Floor = floor;
            Door = door;
            PostalCode = postalCode;
            PublicScapeID = publicScapeID;
        }

        public Guid Id { get; set; }
        public Guid? PublicScapeID { get; set; }
        public string City { get; set; }
        public string PublicSpaceName { get; set; }
        public int House { get; set; }
        public int Floor { get; set; }
        public int Door { get; set; }
        public int PostalCode { get; set; }
        public Guid StudentId { get;set; }
        public Guid TeacherId { get; set; }
        public Guid ParentId { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher{ get; set; }
        public virtual Parent? Parent { get; set; }

        public bool HasId => Id !=Guid.Empty;
    }
}
