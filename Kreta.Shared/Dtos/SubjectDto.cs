using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Shared.Dtos
{
    public class SubjectDto
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string SubjectName { get; set; } = string.Empty;
        public string ShortName {  get; set; } = string.Empty;
        public bool OptionalExaminationSubject { get; set; } = false;
        public bool CompulsoryExaminationSubject { get; set; } = false;
        public ICollection<SchoolClassSubjects>? SchoolClassSubjects { get; set; }
    }
}
