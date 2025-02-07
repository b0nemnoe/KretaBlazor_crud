using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Dtos
{
    public class EducationLevelDto
    {
        public Guid Id { get; set; }
        public string StudentEducationLevel { get; set; } = string.Empty;
        public int DurationOfEducation { get; set; }
        public virtual ICollection<Student>? Students { get; set; } = new List<Student>();
    }
}
