using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Assamblers
{
    public class SubjectTypeAssambler : Assambler<SubjectType, SubjectTypeDto>
    {
        public override SubjectTypeDto ToDto(SubjectType domainEntity)
        {
            return ToDto(domainEntity);
        }

        public override SubjectType ToModel(SubjectTypeDto dto)
        {
            return ToModel(dto);
        }
    }
}
