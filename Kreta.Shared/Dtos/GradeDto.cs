namespace Kreta.Shared.Dtos
{
    public class GradeDto
    {
        public Guid Id { get; set; } = Guid.Empty;
        public int GradeValue { get; set; } = 0;
        public string GradeText { get; set; } = string.Empty;
        public DateTime TimeOfGrade { get; set; } = DateTime.Now;
        public string TypeOfGrade { get; set; } = string.Empty;
    }
}
