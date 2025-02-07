using Kreta.ViewModel;
using Microsoft.AspNetCore.Components;

namespace KretaWeb.Components.Pages.SchoolClasses
{
    public partial class TypeOfEducationPage
    {
        [Inject] ITypeOfEducationViewModel? TypeOfEducationViewModel { get; set; }
        protected  async Task OnInitializedAsync()
        {
            if (TypeOfEducationViewModel is not null)
            {
                await TypeOfEducationViewModel.InitializeAsync();
            }
        }
    }
}
