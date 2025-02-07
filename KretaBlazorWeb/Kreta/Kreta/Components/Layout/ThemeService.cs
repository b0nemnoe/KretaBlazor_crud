using Blazored.LocalStorage;
using MudBlazor;

namespace KretaWeb.Components.Layout
{
    public class ThemeService
    {
        private ILocalStorageService _localStorageService;

        private bool _isCurrentThemeLight = true;
        private MudTheme _darkTheme = new MudTheme();
        private MudTheme _lightTheme = new MudTheme();
        private MudTheme _currentTheme = new MudTheme();

        public string ThemeName => _isCurrentThemeLight ? "light" : "dark";
        public MudTheme CurrentTheme => _currentTheme;

        public ThemeService(ILocalStorageService? localStorageService)
        {
            _localStorageService = localStorageService ?? throw new ArgumentNullException(nameof(localStorageService));
            _darkTheme = ThemeDefinitions.DarkTheme;
            _lightTheme = ThemeDefinitions.LightTheme;
        }

        public async Task InitializeThemeAsync()
        {
            string? theme = ThemeName;
            if (_localStorageService is not null && await _localStorageService.ContainKeyAsync("theme"))
                theme = await _localStorageService.GetItemAsStringAsync("theme");
            _isCurrentThemeLight = theme is not null && theme == "light";
            SetCurrentTheme();
        }

        public async Task ToggleThemeAsync()
        {
            _isCurrentThemeLight = !_isCurrentThemeLight;
            if (_localStorageService is not null)
                await _localStorageService.SetItemAsStringAsync("theme", ThemeName);
            SetCurrentTheme();
        }

        private void SetCurrentTheme()
        {
            _currentTheme = _isCurrentThemeLight ? _lightTheme : _darkTheme;
        }
    }
}
