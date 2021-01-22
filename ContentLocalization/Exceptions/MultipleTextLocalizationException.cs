using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization.Exceptions
{

    [Serializable]
    public class MultipleTextLocalizationException : Exception
    {
        public MultipleTextLocalizationException(string iso) : base($"Multiple localizations for language of ISO code {iso} found.") { }
    }
}
