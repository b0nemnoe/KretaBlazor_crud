using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class AddressRepo<TDbContext> : RepositoryBase<TDbContext, Address>, IAddressRepo
        where TDbContext : DbContext
    {
        public AddressRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
