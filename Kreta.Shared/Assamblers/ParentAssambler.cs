using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Assamblers
{
    public class ParentAssambler : Assambler<Parent, ParentDto>
    {
        public override ParentDto ToDto(Parent model)
        {
            return model.ToDto();
        }

        public override Parent ToModel(ParentDto dto)
        {
            return dto.ToModel();
        }
    }
}
