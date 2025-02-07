using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.HttpService.Services;
using Kreta.Desktop.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Responses;
using Kreta.ViewModel;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class StudentViewModel : StudentViewModelBase
    {
        public StudentViewModel() : base() {}

        public StudentViewModel(IStudentHttpService? httpService) : base(httpService) {}    

        [RelayCommand]
        public async Task DoSave(Student student)
        {
            if (student is not null)
            {
                Response response;
                if (student.HasId)
                    response = await _httpService.UpdateAsync(student);
                else
                    response = await _httpService.InsertAsync(student);
                ClearForm();
                await UpdateViewAsync();
            }
        }

        [RelayCommand]
        public void DoNewStudent()
        {
            ClearForm();
        }

        [RelayCommand]
        public async Task DoDelete(Student student)
        {
            if (student is not null)
            {
                await _httpService.DeleteAsync(student.Id);
                ClearForm();
                await UpdateViewAsync();
            }
        }

        private async Task UpdateViewAsync()
        {
            List<Student> students = await _httpService.GetAllAsync();
            Students = new ObservableCollection<Student>(students);
        }

        private void ClearForm()
        {
            SelectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(SelectedStudent));
        }
    }
}
