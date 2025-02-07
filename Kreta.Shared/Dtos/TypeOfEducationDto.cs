using Kreta.Shared.Models;

namespace Kreta.Shared.Dtos
{
    public class TypeOfEducationDto
    {
        public Guid Id { get; set; }
        public string EducationName { get; set; } = string.Empty;
        public virtual ICollection<SchoolClass>? SchoolClasses { get; set; } = new List<SchoolClass>();
    }
}
