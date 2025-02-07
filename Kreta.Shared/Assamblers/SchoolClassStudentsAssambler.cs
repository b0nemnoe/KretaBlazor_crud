using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Shared.Assamblers
{
    public class SchoolClassStudentsAssambler : Assambler<SchoolClassStudents, SchoolClassStudentsDto>
    {
        public override SchoolClassStudentsDto ToDto(SchoolClassStudents domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override SchoolClassStudents ToModel(SchoolClassStudentsDto dto)
        {
            return dto.ToModel();
        }
    }
}
