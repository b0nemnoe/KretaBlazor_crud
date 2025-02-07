using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Models.SwitchTable
{
    public class TeachersTeachInSchoolClass : IDbEntity<TeachersTeachInSchoolClass>
    {
        public TeachersTeachInSchoolClass(Guid id, Guid teacherId, Guid schoolClassId, int numberOfHours, bool isTheHoursInOne)
        {
            Id = id;
            TeacherId = teacherId;
            SchoolClassId = schoolClassId;
            NumberOfHours = numberOfHours;
            IsTheHoursInOne = isTheHoursInOne;
        }

        public TeachersTeachInSchoolClass()
        {
            Id = Guid.Empty;
            TeacherId = Guid.Empty;
            SchoolClassId = Guid.Empty;
            NumberOfHours = 0;
            IsTheHoursInOne = false;
        }

        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Teacher? TeacherTeachInScoolClass { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClassWhoTeacherTeach {get; set;}
        public int NumberOfHours { get; set; }
        public bool IsTheHoursInOne { get; set; }
        public bool HasId => Id != Guid.Empty;
    }
}
