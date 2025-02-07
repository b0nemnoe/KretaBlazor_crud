using Kreta.Backend.Context;
using Kreta.Shared.Models.SwitchTable;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class TeacherTeachInSchoolClassRepo<TDbContext> : RepositoryBase<TDbContext, TeachersTeachInSchoolClass>, ITeacherTeachInSchoolClass
        where TDbContext : KretaContext
    {
        public TeacherTeachInSchoolClassRepo(TDbContext? dbContext) : base(dbContext)
        {
        }

        public IQueryable<TeachersTeachInSchoolClass> SelectAllIncluded()
        {
            return FindAll().Include(teachersTeachInSchoolClass => teachersTeachInSchoolClass.SchoolClassWhoTeacherTeach)
                            .Include(teachersTeachInSchoolClass => teachersTeachInSchoolClass.TeacherTeachInScoolClass);
        }
    }
}
