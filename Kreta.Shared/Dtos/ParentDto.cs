using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Dtos
{
    public class ParentDto
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public bool IsWoman { get; set; }=false;
        public DateTime BirthDay { get; set; }
        public Guid StudentOfParentId { get; set; }
        public virtual Student? StudentOfParent { get; set; }
        public Guid? AddressId { get; set; }
        public virtual Address? Address { get; set; }

        public string PlaceOfBirth { get; set; } = string.Empty;
        public string MathersName { get; set; } = string.Empty;
    }
}
