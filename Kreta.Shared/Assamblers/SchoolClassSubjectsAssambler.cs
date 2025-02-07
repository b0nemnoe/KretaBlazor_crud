using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Shared.Assamblers
{
    public class SchoolClassSubjectsAssambler : Assambler<SchoolClassSubjects, SchoolClassSubjectsDto>
    {
        public override SchoolClassSubjectsDto ToDto(SchoolClassSubjects domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override SchoolClassSubjects ToModel(SchoolClassSubjectsDto dto)
        {
            return dto.ToModel();
        }
    }
}
