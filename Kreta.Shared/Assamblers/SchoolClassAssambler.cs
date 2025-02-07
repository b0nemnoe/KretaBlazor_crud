using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;

namespace Kreta.Shared.Assamblers
{
    public class SchoolClassAssambler : Assambler<SchoolClass, SchoolClassDto>
    {
        public override SchoolClassDto ToDto(SchoolClass domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override SchoolClass ToModel(SchoolClassDto dto)
        {
            return dto.ToModel();
        }
    }
}
