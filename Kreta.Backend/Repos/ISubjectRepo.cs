using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public interface ISubjectRepo : IRepositoryBase<Subject>
    {
        public IQueryable<Subject> SelectSubjectsWithSchoolClasses();
    }
}
