using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Dtos
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public Guid? EducationLevelId { get; set; }
        public virtual EducationLevel? EducationLevel { get; set; }
        public Guid? SchoolClassID { get; set; }
        public virtual SchoolClass? SchoolClass { get; set; }
        public Guid? MotherId { get; set; }
        public Guid? FatherId { get; set; }
        public Guid? AddressId { get; set; }
        public virtual Parent? Mather { get; set; }
        public virtual Parent? Father { get; set; }
        public virtual Address? Address { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; } = string.Empty;
        public bool IsWoman { get; set; }
    }
}
