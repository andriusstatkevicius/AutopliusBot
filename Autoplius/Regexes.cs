using System.Text.RegularExpressions;

namespace AutopliusCrawler
{
    internal static class Regexes
    {
        internal static RegexOptions RegexOptionsCompiled = RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase;

        internal static Regex UrlsToLoad = new Regex(@"announcement\s*-\s*item[^\u0022]*\u0022\s*href\s*=\s*\u0022*([^\u0022]*)\u0022", RegexOptionsCompiled);

        internal static Regex NextPage = new Regex(@"div\s*class=\s*\u0022*paging\s*-\s*panel.*?(?:<a\s*rel\s*=\s*\u0022*\s*next[^>]*>\s*Kitas)", RegexOptionsCompiled);

        internal static Regex PhoneNumbers = new Regex(@"(?:seller|owner)\s*-\s*phone(?:[^>]*>){1,3}\s*(\+[^<]*)<", RegexOptionsCompiled);

        internal static Regex PhoneNumbers2 = new Regex(@"((?:\+370|8)?\s*[0-9]{3}\s*[0-9]{5})", RegexOptionsCompiled);

        internal static Regex AnnouncementDescription = new Regex(@"announcement\s*-\s*description(.*?)<\/div>", RegexOptionsCompiled);

        internal static Regex CityIDs = new Regex(@"option\s*value[^\u0022]*\u0022([0-9]+)[^>]*>([^<]*)", RegexOptionsCompiled);
    }
}
