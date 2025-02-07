using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private readonly StudentViewModel _studentViewModel;
        private readonly ParentViewModel _parentViewModel;
        private readonly TeacherViewModel _teacherViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();
            _studentViewModel = new StudentViewModel();
            _parentViewModel = new ParentViewModel();
            _teacherViewModel = new TeacherViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel, ParentViewModel parentViewModel, TeacherViewModel teacherViewModel)
        {
            _studentViewModel = studentViewModel;
            _parentViewModel = parentViewModel;
            _teacherViewModel = teacherViewModel;

            CurrentSchoolCitizensChildView = _teacherViewModel;
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public async Task ShowStudentView()
        {
            await _studentViewModel.InitializeAsync();
            CurrentSchoolCitizensChildView = _studentViewModel;
        }

        [RelayCommand]
        public async Task ShowTeacherView()
        {
            await _teacherViewModel.InitializeAsync();
            CurrentSchoolCitizensChildView = _teacherViewModel;
        }

        [RelayCommand]
        public async Task ShowParentView()
        {
            await _parentViewModel.InitializeAsync();
            CurrentSchoolCitizensChildView = _parentViewModel;
        }
    }
}
