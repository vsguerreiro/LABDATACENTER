namespace LABDATACENTER_FORMS.Models
{
    using MudBlazor;
    using MudBlazor.Utilities;

    public static class MyTheme
    {
        public static readonly MudTheme DefaultTheme = new MudTheme();
        public static readonly MudTheme CyanTheme = CreateCyanTheme();
        public static readonly MudTheme RedTheme = CreateRedTheme();
        public static readonly MudTheme IndigoTheme = CreateIndigoTheme();
        public static readonly MudTheme DeepPurpleTheme = CreateDeepPurpleTheme();
        public static readonly MudTheme TealTheme = CreateTealTheme();
        public static readonly MudTheme OrangeTheme = CreateOrangeTheme();
        public static readonly MudTheme BlueGrayTheme = CreateBlueGrayTheme();

        private static MudTheme CreateCyanTheme() => new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.Cyan.Darken2,
                Secondary = Colors.Cyan.Accent4,
                Info = Colors.Cyan.Accent2,
                AppbarBackground = Colors.Cyan.Darken1,
                DrawerBackground = Colors.Cyan.Lighten3,
                Background = Colors.Cyan.Lighten4,
                Surface = Colors.Cyan.Lighten5
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.Cyan.Lighten3,
                Secondary = Colors.Cyan.Darken3,
                Info = Colors.Cyan.Accent1,
                LinesInputs = new MudColor("#FFFFFF"),
            }
        };

        private static MudTheme CreateRedTheme() => new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.Red.Darken2,
                Secondary = Colors.Red.Accent4,
                Info = Colors.Red.Accent2,
                AppbarBackground = Colors.Red.Darken1,
                DrawerBackground = Colors.Red.Lighten3,
                Background = Colors.Red.Lighten4,
                Surface = Colors.Red.Lighten5
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.Red.Lighten3,
                Secondary = Colors.Red.Darken3,
                Info = Colors.Red.Accent1,
                LinesInputs = new MudColor("#FFFFFF"),
            }
        };

        private static MudTheme CreateIndigoTheme() => new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.Indigo.Darken2,
                Secondary = Colors.Indigo.Accent4,
                Info = Colors.Indigo.Accent2,
                AppbarBackground = Colors.Indigo.Darken1,
                DrawerBackground = Colors.Indigo.Lighten3,
                Background = Colors.Indigo.Lighten4,
                Surface = Colors.Indigo.Lighten5
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.Indigo.Lighten3,
                Secondary = Colors.Indigo.Darken3,
                Info = Colors.Indigo.Accent1,
                LinesInputs = new MudColor("#FFFFFF"),
            }
        };

        private static MudTheme CreateDeepPurpleTheme() => new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.DeepPurple.Darken2,
                Secondary = Colors.DeepPurple.Accent4,
                Info = Colors.DeepPurple.Accent2,
                AppbarBackground = Colors.DeepPurple.Darken1,
                DrawerBackground = Colors.DeepPurple.Lighten3,
                Background = Colors.DeepPurple.Lighten4,
                Surface = Colors.DeepPurple.Lighten5
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.DeepPurple.Lighten3,
                Secondary = Colors.DeepPurple.Darken3,
                Info = Colors.DeepPurple.Accent1,
                LinesInputs = new MudColor("#FFFFFF"),
            }
        };

        private static MudTheme CreateTealTheme() => new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.Teal.Darken2,
                Secondary = Colors.Teal.Accent4,
                Info = Colors.Teal.Accent2,
                AppbarBackground = Colors.Teal.Darken1,
                DrawerBackground = Colors.Teal.Lighten3,
                Background = Colors.Teal.Lighten4,
                Surface = Colors.Teal.Lighten5
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.Teal.Lighten3,
                Secondary = Colors.Teal.Darken3,
                Info = Colors.Teal.Accent1,
                LinesInputs = new MudColor("#FFFFFF"),
            }
        };

        private static MudTheme CreateOrangeTheme() => new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.Orange.Darken2,
                Secondary = Colors.Orange.Accent4,
                Info = Colors.Orange.Accent2,
                AppbarBackground = Colors.Orange.Darken1,
                DrawerBackground = Colors.Orange.Lighten3,
                Background = Colors.Orange.Lighten4,
                Surface = Colors.Orange.Lighten5
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.Orange.Lighten3,
                Secondary = Colors.Orange.Darken3,
                Info = Colors.Orange.Accent1,
                LinesInputs = new MudColor("#FFFFFF"),
            }
        };

        private static MudTheme CreateBlueGrayTheme() => new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.BlueGray.Darken2,
                Secondary = Colors.BlueGray.Darken3,
                Info = Colors.BlueGray.Lighten2,
                AppbarBackground = Colors.BlueGray.Darken2,
                DrawerBackground = Colors.BlueGray.Lighten3,
                Background = Colors.BlueGray.Lighten4,
                Surface = Colors.BlueGray.Lighten5
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.BlueGray.Lighten1,
                Secondary = Colors.BlueGray.Darken1,
                Info = Colors.BlueGray.Lighten1,
                LinesInputs = new MudColor("#FFFFFF"),
            }
        };

    }
}
