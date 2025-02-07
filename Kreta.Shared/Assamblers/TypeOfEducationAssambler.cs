using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;

namespace Kreta.Shared.Assamblers
{
    public class TypeOfEducationAssambler : Assambler<TypeOfEducation, TypeOfEducationDto>
    {
        public override TypeOfEducationDto ToDto(TypeOfEducation domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override TypeOfEducation ToModel(TypeOfEducationDto dto)
        {
            return dto.ToModel();
        }
    }
}
