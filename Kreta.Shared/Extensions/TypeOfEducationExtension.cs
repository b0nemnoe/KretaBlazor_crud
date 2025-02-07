using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Extensions
{
    public static class TypeOfEducationExtension
    {
        public static TypeOfEducationDto ToDto(this TypeOfEducation typeOfEducation)
        {
            return new TypeOfEducationDto
            {
                Id = typeOfEducation.Id,
                EducationName = typeOfEducation.EducationName,
                SchoolClasses = typeOfEducation.SchoolClasses,
            };
        }

        public static TypeOfEducation ToModel(this TypeOfEducationDto typeOfEducationDto)
        {
            return new TypeOfEducation
            {
                Id = typeOfEducationDto.Id,
                EducationName = typeOfEducationDto.EducationName,
                SchoolClasses = typeOfEducationDto.SchoolClasses,
            };
        }
    }
}
