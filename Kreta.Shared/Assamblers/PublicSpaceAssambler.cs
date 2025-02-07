using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;

namespace Kreta.Shared.Assamblers
{
    public class PublicSpaceAssambler : Assambler<PublicSpace, PublicSpaceDto>
    {
        public override PublicSpaceDto ToDto(PublicSpace domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override PublicSpace ToModel(PublicSpaceDto dto)
        {
            return dto.ToModel();
        }
    }
}
