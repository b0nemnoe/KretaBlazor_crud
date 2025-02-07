
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models.SwitchTable;
using System.Collections;

namespace Kreta.Shared.Models
{
    public class SchoolClass : IDbEntity<SchoolClass>
    {
        public SchoolClass()
        {
            Id = Guid.Empty;
            SchoolYear = -1;
            SchoolClassType = SchoolClassType.ClassA;
            TypeOfEducationId = Guid.Empty;
            YearOfEnrolment = -1;
            IsArchived = false;
            HeadTeacherId = Guid.Empty;
        }

        public SchoolClass(Guid id, int schoolYear, SchoolClassType schoolClassType, int yearOfEnrolment, bool isArchived, Guid typeOfEducationId, Guid headTeacherId)
        {
            Id = id;
            SchoolYear = schoolYear;
            SchoolClassType = schoolClassType;
            TypeOfEducationId = typeOfEducationId;
            YearOfEnrolment = yearOfEnrolment;
            IsArchived = isArchived;
            HeadTeacherId = headTeacherId;
        }

        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
        public Guid? TypeOfEducationId { get; set; }
        public virtual TypeOfEducation? TypeOfEducation { get; set; }
        public Guid? HeadTeacherId { get; set; }
        public virtual Teacher? HeadTeacher {get;set;}
        public int YearOfEnrolment {  get; set; }
        public bool IsArchived { get; set; }
        public virtual ICollection<SchoolClassSubjects>? SchoolClassSubjects { get; set; }
        public virtual ICollection<Student>? StudentsOfClass { get; set; }
        public virtual ICollection<TeachersTeachInSchoolClass>? TeacherWhoTeachInSchoolClass { get; set; }
        public string SchoolClassTypeName
        {
            get
            {
                string className = string.Empty;
                switch (SchoolClassType)
                {
                    case SchoolClassType.ClassA: className = "a"; break;
                    case SchoolClassType.ClassB: className = "b"; break;
                    case SchoolClassType.ClassC: className = "c"; break;
                }
                return className;
            }
        }
        public string SchoolClassName => $"{SchoolYear}.{SchoolClassTypeName} ({YearOfEnrolment})";

        public override string ToString()
        {
            string className = string.Empty;
            switch (SchoolClassType)
            {
                case SchoolClassType.ClassA: className = "a"; break;
                case SchoolClassType.ClassB: className = "b"; break;
                case SchoolClassType.ClassC: className = "c"; break;
            }
            string typeOfEducation = TypeOfEducation is not null ? TypeOfEducation.ToString() : string.Empty;
            string archived = IsArchived ? "archivált" : string.Empty;
            return $"{SchoolYear}.{className} ({YearOfEnrolment}) {typeOfEducation} {archived}";
        }
    }
}
