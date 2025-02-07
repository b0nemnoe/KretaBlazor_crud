using Kreta.Backend.Repos.Managers;
using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public interface IStatisticRepo
    {
        public int GetNumberOfParents();
        public GenderNumberOfParent GetGenderNumberOfParent();
        public List<NumberOfStudentByClass> GetNumberOfStudentByClasses();
    }
}
