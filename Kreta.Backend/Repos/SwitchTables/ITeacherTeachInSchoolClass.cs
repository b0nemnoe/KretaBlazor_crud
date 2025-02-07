using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Backend.Repos.SwitchTables
{
    public interface ITeacherTeachInSchoolClass : IRepositoryBase<TeachersTeachInSchoolClass>
    {
        public IQueryable<TeachersTeachInSchoolClass> SelectAllIncluded();
    }
}
