using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public interface ITypeOfEducationRepo : IRepositoryBase<TypeOfEducation>
    {
        public IQueryable<TypeOfEducation> SelectAllIncluded();
    }
}
