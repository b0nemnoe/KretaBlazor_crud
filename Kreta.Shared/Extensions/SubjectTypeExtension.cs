using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class SubjectTypeExtension
    {
        public static SubjectTypeDto ToDto(this SubjectType subjectType)
        {
            return new SubjectTypeDto
            {
                Id = subjectType.Id,
                SubjectTypeName = subjectType.SubjectTypeName,
            };
        }
        public static SubjectType ToModel(this SubjectTypeDto subjectTypeDto)
        {
            return new SubjectType
            {
                Id = subjectTypeDto.Id,
                SubjectTypeName = subjectTypeDto.SubjectTypeName,
            };
        }

    }
}
