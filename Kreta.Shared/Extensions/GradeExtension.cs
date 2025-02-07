using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class GradeExtension
    {
        public static GradeDto ToDto(this Grade student)
        {
            return new GradeDto
            {
                Id = student.Id,
                GradeValue = student.GradeValue,
                GradeText = student.GradeText,
                TimeOfGrade = student.TimeOfGrade,
                TypeOfGrade = student.TypeOfGrade,

            };
        }

        public static Grade ToModel(this GradeDto studentDto)
        {
            return new Grade
            {
                Id = studentDto.Id,
                GradeText= studentDto.GradeText,
                GradeValue= studentDto.GradeValue,
                TypeOfGrade= studentDto.TypeOfGrade,
                TimeOfGrade= studentDto.TimeOfGrade,

            };
        }
    }
}
