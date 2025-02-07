using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Shared.Dtos
{
    public class SchoolClassDto
    {
        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
        public Guid? TypeOfEducationId { get; set; }
        public virtual TypeOfEducation? TypeOfEducation { get; set; }
        public Guid? HeadTeacherId { get; set; }
        public virtual Teacher? HeadTeacher { get; set; }
        public int YearOfEnrolment { get; set; }
        public bool IsArchived { get; set; }
        public ICollection<SchoolClassSubjects>? SchoolClassSubjects { get; set; }
        public virtual ICollection<Student>? StudentsOfClass { get; set; }
        public virtual ICollection<TeachersTeachInSchoolClass>? TeacherWhoTeachInSchoolClass { get; set; }
    }
}
