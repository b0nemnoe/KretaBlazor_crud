using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public partial class TypeOfEducationViewModel : BaseViewModel, ITypeOfEducationViewModel
    {
        protected readonly ITypeOfEducationHttpService _httpService;

        [ObservableProperty]
        protected TypeOfEducation _selectedTypeOfEducation = new TypeOfEducation();


        [ObservableProperty]
        protected ObservableCollection<TypeOfEducation> _typeOfEducations = new ObservableCollection<TypeOfEducation>();

        public TypeOfEducationViewModel()
        {
            SelectedTypeOfEducation = new TypeOfEducation();
            _httpService = new TypeOfEducationHttpService();
        }

        public TypeOfEducationViewModel(ITypeOfEducationHttpService? httpService)
        {
            _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));
            SelectedTypeOfEducation = new TypeOfEducation();
        }
        public override async Task InitializeAsync()
        {
            await UpdateViewAsync();
            await base.InitializeAsync();
        }

        private async Task UpdateViewAsync()
        {
            List<TypeOfEducation> typeOfEducations = await _httpService.GetAllAsync();
            TypeOfEducations = new ObservableCollection<TypeOfEducation>(typeOfEducations);
        }
    }
}
