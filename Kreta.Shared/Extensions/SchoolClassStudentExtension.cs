using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Shared.Extensions
{
    public static class SchoolClassStudentExtension
    {
        public static SchoolClassStudentsDto ToDto(this SchoolClassStudents model)
        {
            return new SchoolClassStudentsDto
            {
                Id = model.Id,
                SchoolClassId = model.SchoolClassId,
                SchoolClass = model.SchoolClass,
                StudnetId = model.StudnetId,
                Student = model.Student,
                DateOfEnrolment = model.DateOfEnrolment,
            };
        }

        public static SchoolClassStudents ToModel(this SchoolClassStudentsDto dto)
        {
            return new SchoolClassStudents
            {
                Id = dto.Id,
                SchoolClassId = dto.SchoolClassId,
                SchoolClass = dto.SchoolClass,
                StudnetId = dto.StudnetId,
                Student = dto.Student,
                DateOfEnrolment = dto.DateOfEnrolment,
            };
        }
    }            
}
