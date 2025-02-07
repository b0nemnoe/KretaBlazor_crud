using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SchoolClassRepo<TDbContext> : RepositoryBase<TDbContext, SchoolClass>, ISchoolClassRepo
        where TDbContext : DbContext
    {
        public SchoolClassRepo(TDbContext? dbContext) : base(dbContext)
        {
        }

        public IQueryable<SchoolClass> SelectAllIncluded()
        {
            return FindAll().Include(schoolClass => schoolClass.TypeOfEducation);
        }

        public IQueryable<SchoolClass> GetSchoolClassBy(Guid typeOfEducationID)
        {
            return FindAll().Where(schoolClass => schoolClass.TypeOfEducationId == typeOfEducationID);
        }

        public IQueryable<SchoolClass> SelectWithoutTypeOfEducation()
        {
            return FindAll().Where(schoolClass =>
              schoolClass.TypeOfEducationId == null ||
              schoolClass.TypeOfEducationId == Guid.Empty);
        }

        public IQueryable<SchoolClass> SelectSchoolClassesWithSubjects()
        {
            return FindAll()
                    .Include(schoolClasses => schoolClasses.SchoolClassSubjects)
                    .ThenInclude(schoolClassSubjects => schoolClassSubjects.Subject);
        }
    }
}
