using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization.Exceptions
{

    [Serializable]
    public class LanguageNotFoundException : Exception
    {
        public LanguageNotFoundException(string iso) : base($"Couldn't find language of ISO code {iso}") { }
    }
}
