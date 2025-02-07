using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;

namespace Kreta.Shared.Assamblers
{
    public class GradeAssambler : Assambler<Grade, GradeDto>
    {
        public override GradeDto ToDto(Grade model)
        {
            return model.ToDto();
        }

        public override Grade ToModel(GradeDto dto)
        {
            return dto.ToModel();
        }
    }
}
