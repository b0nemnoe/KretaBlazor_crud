using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToDto(this Student student)
        {
            return new StudentDto
            {
                Id = student.Id,
                EducationLevelId = student.EducationLevelId,
                SchoolClassID = student.SchoolClassID,
                SchoolClass = student.SchoolClass,
                MotherId = student.MotherId,
                FatherId = student.FatherId,
                AddressId = student.AddressId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDay = student.BirthDay,
                PlaceOfBirth = student.PlaceOfBirth,    
                IsWoman = student.IsWoman,
                EducationLevel = student.EducationLevel,
                Mather=student.Mather,
                Father=student.Father,
                //Address=student.Address,
            };
        }

        public static Student ToModel(this StudentDto studentdto)
        {
            return new Student
            {
                Id = studentdto.Id,
                EducationLevelId = studentdto.EducationLevelId,
                SchoolClassID=studentdto.SchoolClassID,
                SchoolClass = studentdto.SchoolClass,
                MotherId=studentdto.MotherId,
                FatherId=studentdto.FatherId,
                AddressId = studentdto.AddressId,
                FirstName = studentdto.FirstName,
                LastName = studentdto.LastName,
                BirthDay = studentdto.BirthDay,
                PlaceOfBirth=studentdto.PlaceOfBirth,
                IsWoman=studentdto.IsWoman,
                EducationLevel=studentdto.EducationLevel,
                Mather=studentdto.Mather,
                Father= studentdto.Father,
                //Address=studentdto.Address,

            };
        }
    }

}
