namespace Kreta.Shared.Models
{
    public class Grade : IDbEntity<Grade>
    {
        public Grade()
        {
            Id = Guid.Empty;
            GradeValue = 0;
            GradeText = string.Empty;
            TimeOfGrade = DateTime.Now;
            TypeOfGrade = string.Empty;
        }

        public Grade(Guid id, int gradeValue, string gradeText, DateTime timeOfGrade, string typeOfGrade)
        {
            Id = id;
            GradeValue = gradeValue;
            GradeText = gradeText;
            TimeOfGrade = timeOfGrade;
            TypeOfGrade = typeOfGrade;
        }

        public Guid Id { get; set; }
        public int GradeValue { get; set; }
        public string GradeText { get; set; }
        public DateTime TimeOfGrade { get; set; }
        public string TypeOfGrade { get; set; }
        public bool HasId => Id != Guid.Empty;

        public override string ToString()
        {
            return $"{GradeValue} ({GradeText})";
        }

    }
}
