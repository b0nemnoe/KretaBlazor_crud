using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToDto(this Teacher teacher)
        {
            return new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                BirthDay = teacher.BirthDay,
                IsHeadTeacher = teacher.IsHeadTeacher,
                PlaceOfBirth = teacher.PlaceOfBirth,
                IsWoman = teacher.IsWoman,
                MathersName = teacher.MathersName,
                HeadTeacherFoClass= teacher.HeadTeacherFoClass,
                HeadTeacherForShoolClassId=teacher.HeadTeacherForShoolClassId,
                //Address= teacher.Address,
                SchoolClassWhereTeacherTeach = teacher.SchoolClassWhereTeacherTeach,
            };
        }

        public static Teacher ToModel(this TeacherDto teacherdto)
        {
            return new Teacher
            {
                Id = teacherdto.Id,
                FirstName = teacherdto.FirstName,
                LastName = teacherdto.LastName,
                BirthDay = teacherdto.BirthDay,
                IsHeadTeacher = teacherdto.IsHeadTeacher,
                PlaceOfBirth = teacherdto.PlaceOfBirth,
                IsWoman = teacherdto.IsWoman,
                MathersName = teacherdto.MathersName,
                HeadTeacherFoClass = teacherdto.HeadTeacherFoClass,
                HeadTeacherForShoolClassId = teacherdto.HeadTeacherForShoolClassId,
                //Address = teacherdto.Address,
                SchoolClassWhereTeacherTeach = teacherdto.SchoolClassWhereTeacherTeach,
            };
        }
    }

}
