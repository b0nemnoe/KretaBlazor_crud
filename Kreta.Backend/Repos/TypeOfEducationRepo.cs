using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class TypeOfEducationRepo<TDbContext> : RepositoryBase<TDbContext, TypeOfEducation>, ITypeOfEducationRepo
        where TDbContext : DbContext
    {
        public TypeOfEducationRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
        public IQueryable<TypeOfEducation> SelectAllIncluded()
        {
            return FindAll().Include(typeOfEducation => typeOfEducation.SchoolClasses);
        }
    }
}
