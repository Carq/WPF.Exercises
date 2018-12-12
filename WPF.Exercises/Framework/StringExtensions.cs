using System.Globalization;

namespace WPF.Exercises.Framework
{
    public static class StringExtensions
    {
        public static bool ContainsIgnoreDiacritics(this string @this, string value)
        {
            return CultureInfo.InvariantCulture.CompareInfo
                .IndexOf(@this, value, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) != -1;
        }
    }
}
