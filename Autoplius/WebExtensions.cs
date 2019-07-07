using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace AutopliusCrawler
{
    public static class WebExtensions
    {
        public static string GetPageUrl(this HttpWebResponse input)
        {
            return input?.ResponseUri?.ToString();
        }

        public static string ToStringValue(this HttpWebResponse input)
        {
            return new StreamReader(input.GetResponseStream()).ReadToEnd();
        }
    }
}
