using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SwitchTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Extensions
{
    public static class TeachersTeachInSchoolClassExtension
    {
        public static TeachersTeachInSchoolClassDto ToDto(this TeachersTeachInSchoolClass model)
        {
            return new TeachersTeachInSchoolClassDto
            {
                Id = model.Id,
                TeacherId = model.TeacherId,
                SchoolClassId = model.SchoolClassId,
                TeacherTeachInScoolClass = model.TeacherTeachInScoolClass,
                SchoolClassWhoTeacherTeach = model.SchoolClassWhoTeacherTeach,
            };               
        }

        public static TeachersTeachInSchoolClass ToModel(this TeachersTeachInSchoolClassDto dto)
        {
            return new TeachersTeachInSchoolClass
            {
                Id = dto.Id,
                TeacherId = dto.TeacherId,
                SchoolClassId = dto.SchoolClassId,
                TeacherTeachInScoolClass = dto.TeacherTeachInScoolClass,
                SchoolClassWhoTeacherTeach = dto.SchoolClassWhoTeacherTeach,
            };
        }
    }                        
}
        

