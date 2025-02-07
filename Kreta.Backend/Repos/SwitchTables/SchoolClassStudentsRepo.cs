using Kreta.Backend.Context;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class SchoolClassStudentsRepo<TDbContext> : RepositoryBase<TDbContext, SchoolClassStudents>, ISchoolClassStudentsRepo
        where TDbContext : KretaContext
    {
        public SchoolClassStudentsRepo(TDbContext? dbContext) : base(dbContext)
        {
        }

        public IQueryable<SchoolClassStudents> SelectAllIncluded()
        {
            return FindAll().Include(schoolClassSubjects => schoolClassSubjects.SchoolClass)
                            .Include(SchoolClassSubjects => SchoolClassSubjects.Student);
        }
    }
}
