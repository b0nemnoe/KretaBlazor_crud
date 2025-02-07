using Kreta.Backend.Repos.Managers;
using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public class StatisticRepo : IStatisticRepo
    {
        private readonly IRepositoryManager? _repositoryManager;

        public StatisticRepo(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public int GetNumberOfParents()
        {
            return _repositoryManager.ParentRepo
                .FindAll()
                .Count();
        }

        public GenderNumberOfParent GetGenderNumberOfParent()
        {
            GenderNumberOfParent number=new GenderNumberOfParent();
            number.FemaleNumber=_repositoryManager
                .ParentRepo
                .FindAll()
                .Where(parent => parent.IsWoman)
                .Count();
            number.MaleNumber = _repositoryManager.ParentRepo
                .FindAll()
                .Where(parent => !parent.IsWoman)
                .Count();
            return number;
        }

        public List<NumberOfStudentByClass> GetNumberOfStudentByClasses()
        {
            List<NumberOfStudentByClass> numberOfStudentByClasses = new();
            List<SchoolClass> schoolClasses = _repositoryManager
                .SchoolClassRepo
                .FindAll()
                .ToList();

            foreach(SchoolClass schoolClass in schoolClasses)
            {
                int number=_repositoryManager
                    .StudentRepo
                    .FindAll()
                    .Where(student => student.SchoolClassID == schoolClass.Id)
                    .Count();
                NumberOfStudentByClass nsc = new NumberOfStudentByClass
                {
                    Grade = schoolClass.SchoolYear,
                    Type = schoolClass.SchoolClassType,
                    NumberOfStudent = number,
                };
                numberOfStudentByClasses.Add(nsc);
            }
            return numberOfStudentByClasses;
        }
    }
}
