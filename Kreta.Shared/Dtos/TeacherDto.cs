using Kreta.Shared.Models;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Shared.Dtos
{
    public class TeacherDto
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string PlaceOfBirth { get; set; } = string.Empty;
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
        public Guid HeadTeacherForShoolClassId { get; set; }
        public virtual SchoolClass? HeadTeacherFoClass { get; set; }
        public string MathersName { get; set; } = string.Empty;
        public Guid? AddressId { get; set; }
        //public virtual Address? Address { get; set; }
        public virtual ICollection<TeachersTeachInSchoolClass>? SchoolClassWhereTeacherTeach { get; set; }

    }
}
