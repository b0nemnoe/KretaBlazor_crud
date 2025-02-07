using MudBlazor;

namespace KretaWeb.Components.Layout
{
    public static class ThemeDefinitions
    {
        public static readonly MudTheme DarkTheme = new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                AppbarBackground = "#0097FF",
                AppbarText = "#FFFFFF",
                Background = "#001524",
                Primary = "#007CD1",
                Secondary = "#117CE1",
                Tertiary = "#107C51",
                TextPrimary = "#FFFFFF",
                TextSecondary = "#FEFEFE",
                DrawerBackground = "#093958",
                DrawerText = "#FFFFFF",
                Surface = "#093958",
                ActionDefault = "#0097FF",
                ActionDisabled = "#2F678C",
                TextDisabled = "#B0B0B0"
            }
        };

        public static readonly MudTheme LightTheme = new MudTheme()
        {
            PaletteLight = new PaletteLight()
            {
                AppbarBackground = "#0097FF",
                AppbarText = "#FFFFFF",
                Background = "#F4FDFF",
                Primary = "#007CD1",
                Secondary = "#117CE1",
                Tertiary = "#107C51",
                TextPrimary = "#0C1217",
                TextSecondary = "#0C1217",
                DrawerBackground = "#C5E5FF",
                DrawerText = "#0C1217",
                Surface = "#E4FAFF",
                ActionDefault = "#0C1217",
                ActionDisabled = "#2F678C",
                TextDisabled = "#676767"
            }
        };
    }
}
