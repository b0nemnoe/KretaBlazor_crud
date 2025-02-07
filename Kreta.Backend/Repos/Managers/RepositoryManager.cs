using Kreta.Backend.Repos.SwitchTables;

namespace Kreta.Backend.Repos.Managers
{
    public class RepositoryManager : IRepositoryManager
    {
        private IAddressRepo? _addressRepo;
        private IEducationLevelRepo? _educationLevelRepo;
        private IGradeRepo? _gradeRepo;
        private IParentRepo? _parentRepo;
        private IPublicSpaceRepo? _publicSpaceRepo;
        private ISchoolClassRepo? _schooolClassRepo;
        private IStudentRepo? _studentRepo;
        private ISubjectRepo? _subjectRepo;
        private ISubjectTypeRepo? _subjectTypeRepo;
        private ITeacherRepo? _teacherRepo;
        private ITypeOfEducationRepo? _typeOfEducationRepo;

        private ISchoolClassSubjectsRepo? _schoolClassSubjectsRepo;

        public RepositoryManager(
            IAddressRepo? addressRepo,
            IEducationLevelRepo? educationLevelRepo,
            IGradeRepo? gradeRepo,
            IParentRepo? parentRepo,
            IPublicSpaceRepo? publicSpaceRepo,
            IStudentRepo? studentRepo,
            ISchoolClassRepo? schoolClassRepo,
            ISubjectRepo? subjectRepo,
            ISubjectTypeRepo subjectTypeRepo,
            ISchoolClassSubjectsRepo? schoolClassSubjectsRepo,
            ITeacherRepo? teacherRepo,
            ITypeOfEducationRepo? _typeOfEducationRepo
            )
        {
            _addressRepo = addressRepo;
            _educationLevelRepo = educationLevelRepo;
            _gradeRepo = gradeRepo;
            _parentRepo= parentRepo;
            _publicSpaceRepo= publicSpaceRepo;
            _schooolClassRepo = schoolClassRepo;
            _studentRepo=studentRepo;
            _subjectRepo = subjectRepo;
            _schoolClassSubjectsRepo = schoolClassSubjectsRepo;
            _subjectTypeRepo = subjectTypeRepo;
            _teacherRepo = teacherRepo;
            _teacherRepo=teacherRepo;
        }
        public IAddressRepo? AddressRepo => _addressRepo;
        public IEducationLevelRepo? EducationLevelRepo => _educationLevelRepo;
        public IGradeRepo? GradeRepo => _gradeRepo;
        public IParentRepo? ParentRepo => _parentRepo;
        public IPublicSpaceRepo? PublicSpaceRepo => _publicSpaceRepo;
        public ISchoolClassRepo? SchoolClassRepo => _schooolClassRepo;
        public IStudentRepo? StudentRepo => _studentRepo;
        public ISubjectRepo? SubjectRepo => _subjectRepo;
        public ISchoolClassSubjectsRepo? SchoolClassSubjectsRepo => _schoolClassSubjectsRepo;
        public ISubjectTypeRepo? SubjectTypeRepo => _subjectTypeRepo;
        public ITeacherRepo? TeacherRepo => _teacherRepo;
        public ITypeOfEducationRepo? TypeOfEducationRepo => _typeOfEducationRepo;
    }
}
