using Kreta.Shared.Models;
using Kreta.Shared.Responses;

namespace Kreta.Backend.Services
{
    public interface ISchoolClassSubjectService
    {
        public IQueryable<Subject> SelectSubjectNoStudiedInTheSchoolClass(Guid schoolClassId);
        public IQueryable<SchoolClass> SelectSchoolClassWhoNotStudyingSubject(Guid subjectId);
    }
}
