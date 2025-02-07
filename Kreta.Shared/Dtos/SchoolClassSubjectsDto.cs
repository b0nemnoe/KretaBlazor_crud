using Kreta.Shared.Models;

namespace Kreta.Shared.Dtos
{
    public class SchoolClassSubjectsDto
    {
        public Guid Id { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClass { get; set; }
        public Guid SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsTheHoursInOne { get; set; }
    }
}
