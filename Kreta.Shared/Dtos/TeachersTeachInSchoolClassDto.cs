using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Models;

namespace Kreta.Shared.Dtos
{
    public class TeachersTeachInSchoolClassDto
    {
        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Teacher? TeacherTeachInScoolClass { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClassWhoTeacherTeach { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsTheHoursInOne { get; set; }
    }
}
