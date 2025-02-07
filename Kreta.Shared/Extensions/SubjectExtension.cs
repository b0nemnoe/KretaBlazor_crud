using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class SubjectExtension
    {
        public static SubjectDto ToDto(this Subject subject)
        { 
            return new SubjectDto
            {
                Id = subject.Id,
                SubjectName = subject.SubjectName,
                ShortName = subject.ShortName,
                CompulsoryExaminationSubject=subject.CompulsoryExaminationSubject,
                OptionalExaminationSubject = subject.OptionalExaminationSubject,
                SchoolClassSubjects = subject.SchoolClassSubjects,
            };
        }

        public static Subject ToModel(this SubjectDto subjectDto)
        {
            return new Subject
            {
                Id = subjectDto.Id,
                ShortName=subjectDto.ShortName,
                SubjectName=subjectDto.SubjectName,
                CompulsoryExaminationSubject=subjectDto.CompulsoryExaminationSubject,
                OptionalExaminationSubject= subjectDto.OptionalExaminationSubject,
                SchoolClassSubjects = subjectDto.SchoolClassSubjects,
            };
        }
    }
}
