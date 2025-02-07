using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class PublicSpaceRepo<TDbContext> : RepositoryBase<TDbContext, PublicSpace>, IPublicSpaceRepo
        where TDbContext : DbContext
    {
        public PublicSpaceRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
