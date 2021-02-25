using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Localization.Models
{
    public class CultureSwitcherModel
    {
        public CultureInfo CurrentUICulture { get; set; }
        public List<CultureInfo> SupportedCultures { get; set; }
    }
}