using Kreta.Backend.Repos.SwitchTables;

namespace Kreta.Backend.Repos.Managers
{
    public interface IRepositoryManager
    {
        public IAddressRepo? AddressRepo { get; }
        public IEducationLevelRepo? EducationLevelRepo { get; }
        public IGradeRepo? GradeRepo { get; }
        public IParentRepo? ParentRepo { get; }
        public IPublicSpaceRepo? PublicSpaceRepo { get; }
        public ISchoolClassRepo? SchoolClassRepo { get; }
        public IStudentRepo? StudentRepo { get; }
        public ISubjectRepo? SubjectRepo { get; }
        public ISchoolClassSubjectsRepo? SchoolClassSubjectsRepo { get; }
        public ISubjectTypeRepo? SubjectTypeRepo { get; }
        public ITeacherRepo? TeacherRepo { get; }
        public ITypeOfEducationRepo? TypeOfEducationRepo { get; }
    }
}
