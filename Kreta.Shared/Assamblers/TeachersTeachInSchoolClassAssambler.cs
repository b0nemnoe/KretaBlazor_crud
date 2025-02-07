using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Shared.Assamblers
{
    public class TeachersTeachInSchoolClassAssambler : Assambler<TeachersTeachInSchoolClass, TeachersTeachInSchoolClassDto>
    {
        public override TeachersTeachInSchoolClassDto ToDto(TeachersTeachInSchoolClass domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override TeachersTeachInSchoolClass ToModel(TeachersTeachInSchoolClassDto dto)
        {
            return dto.ToModel();
        }
    }
}
