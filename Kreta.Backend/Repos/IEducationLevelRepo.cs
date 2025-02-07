using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Backend.Repos
{
    public interface IEducationLevelRepo : IRepositoryBase<EducationLevel>
    {
        public IQueryable<EducationLevel> SelectAllIncluded();
    }
}
