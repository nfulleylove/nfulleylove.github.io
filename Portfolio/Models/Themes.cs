using MudBlazor;

namespace Portfolio.Models;

internal static class Themes
{
    internal static MudTheme Light => new MudTheme()
    {
        Palette = new PaletteLight()
        {
            Primary = "#07485B",
            Secondary = "#009586"
        },
        Typography = new()
        {
            H1 = new H1() { FontFamily = new[] { "Kanit" }, FontWeight = 500 },
            H2 = new H2() { FontFamily = new[] { "Kanit" }, FontWeight = 500 },
            H3 = new H3() { FontFamily = new[] { "Kanit" }, FontWeight = 500 },
            H4 = new H4() { FontFamily = new[] { "Kanit" }, FontWeight = 500 },
            H5 = new H5() { FontFamily = new[] { "Kanit" }, FontWeight = 500 },
            Body1 = new() { FontFamily = new[] { "Kanit" }, FontWeight = 300 }

        }
    };
}
