using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class EducationLevelExtension
    {
        public static EducationLevelDto ToDto(this EducationLevel educationLevel)
        {
            return new EducationLevelDto
            {
                Id = educationLevel.Id,
                StudentEducationLevel = educationLevel.StudentEducationLevel,
                DurationOfEducation=educationLevel.DurationOfEducation,
                Students = educationLevel.Students,
            };
        }

        public static EducationLevel ToModel(this EducationLevelDto model)
        {
            return new EducationLevel
            {
                Id = model.Id,
                StudentEducationLevel = model.StudentEducationLevel,
                DurationOfEducation=model.DurationOfEducation,
                Students = model.Students,
            };
        }            
    }
}
