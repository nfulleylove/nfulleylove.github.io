using MudBlazor;

namespace Portfolio.Models;

internal static class Themes
{
    internal static MudTheme Light => new MudTheme()
    {
        Palette = new PaletteLight()
        {
            Primary = Colors.Indigo.Default,
            Secondary = Colors.Indigo.Accent2,
            Tertiary = Colors.Amber.Default
        }
    };
}
