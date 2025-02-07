using Blazored.LocalStorage;
using KretaWeb.Components.Layout;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Kreta.Components.Layout
{
    public partial class MainLayout
    {
        bool _drawerOpen = true;
        [Inject] public ThemeService? ThemeService { get; set; } = default!;

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (ThemeService is not null)
                await ThemeService.InitializeThemeAsync();
            await base.OnAfterRenderAsync(firstRender);
        }
        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
