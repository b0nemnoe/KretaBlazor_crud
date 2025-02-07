using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SubjectTypeRepo<TDbContext> : RepositoryBase<TDbContext, SubjectType>, ISubjectTypeRepo
        where TDbContext : DbContext
    {
        public SubjectTypeRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
