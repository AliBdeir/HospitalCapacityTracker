using HospitalBedTracker.Data.DataTypes;
using Localization.Exceptions;
using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Localization
{
    public static class Extensions
    {
        public static string DefaultLanguageISO { get; set; } = "en-us";

        public static string Localization<T>(this IEnumerable<T> ts,
            RequestCulture culture) where T : LocalizedText
        {
            return Localization(ts, culture.UICulture.Name);
        }

        public static string Localization<T>(this IEnumerable<T> ts, string iso) where T : LocalizedText
        {
            try
            {
                var result = ts.SingleOrDefault(x => x.LanguageISO.ToLower() == iso.ToLower()).Text;
                if (result == null)
                {
                    throw new LanguageNotFoundException(iso);
                }
                return result;
            }
            catch (InvalidOperationException)
            {
                throw new MultipleTextLocalizationException(iso);
            }
        }

        public static string LocalizationOrDefault<T>(this IEnumerable<T> ts,
            RequestCulture culture, 
            bool emptyIfNone = true) where T: LocalizedText
        {
            return LocalizationOrDefault(ts, culture.UICulture.Name, emptyIfNone);
        }

        public static string LocalizationOrDefault<T>(this IEnumerable<T> ts,
            string iso,
            bool emptyIfNone = true) where T : LocalizedText
        {
            if (ts == null)
            {
                throw new ArgumentNullException(nameof(ts));
            }
            string result = ts.SingleOrDefault(x => x.LanguageISO.ToLower() == iso.ToLower())?.Text;
            if (result == default)
            {
                var manualDefault = ts.SingleOrDefault(x => x.LanguageISO.ToLower() == DefaultLanguageISO.ToLower())?.Text;
                if (manualDefault == null)
                {
                    return emptyIfNone ? string.Empty : throw new LanguageNotFoundException(iso);
                }
                return manualDefault;
            }
            return result;
        }

        public static IEnumerable<T> ToLT<T>(this Dictionary<string,string> values) where T : LocalizedText, new()
        {
            foreach (var kvp in values)
            {
                yield return new () { LanguageISO = kvp.Key, Text = kvp.Value };
            }
        }

    }
}
