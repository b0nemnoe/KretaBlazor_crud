using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models;

namespace Kreta.Shared.Dtos
{
    public class SchoolClassStudentsDto
    {
        public Guid Id { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClass { get; set; }
        public Guid StudnetId { get; set; }
        public virtual Student? Student { get; set; }
        public DateOnly? DateOfEnrolment { get; set; }
    }
}
