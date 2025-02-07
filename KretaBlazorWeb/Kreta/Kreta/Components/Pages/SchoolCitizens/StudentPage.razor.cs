using Kreta.ViewModel;
using Microsoft.AspNetCore.Components;

namespace Kreta.Components.Pages.SchoolCitizens
{
    public partial class StudentPage
    {
        [Inject] IStudentViewModelBase? StudentViewModel { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (StudentViewModel != null)
            {
                await StudentViewModel.InitializeAsync();
            }
            await base.OnInitializedAsync();
        }
    }
}
