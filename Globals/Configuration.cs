using System;
using System.Globalization;

namespace Globals
{
    public static class Configuration
    {
        public static CultureInfo[] SupportedLanguages => new CultureInfo[]
        {
            new CultureInfo("en"),
            new CultureInfo("ar")
        };
    }
}
