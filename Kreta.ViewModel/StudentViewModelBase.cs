using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.ViewModel.Base;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public partial class StudentViewModelBase : BaseViewModel, IStudentViewModelBase
    {
        protected readonly IStudentHttpService _httpService;

        [ObservableProperty]
        protected Student _selectedStudent = new Student();

        [ObservableProperty]
        protected List<string> _educationLevels = new List<string> { "érettségi", "szakmai érettségi", "szakmai vizsga" };

        [ObservableProperty]
        protected ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public StudentViewModelBase()
        {
            SelectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
            _httpService = new StudentHttpService();
        }

        public StudentViewModelBase(IStudentHttpService? httpService)
        {
            _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));
            SelectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
        }
        public override async Task InitializeAsync()
        {
            await UpdateViewAsync();
            await base.InitializeAsync();
        }

        private async Task UpdateViewAsync()
        {
            List<Student> students = await _httpService.GetAllAsync();
            Students = new ObservableCollection<Student>(students);
        }
    }
}
