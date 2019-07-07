using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace AutopliusCrawler
{
    public class Crawler
    {
        public List<IEnumerable<string>> ExtractElementsToIEnumerableList(string source, Regex regex)
        {
            if (!string.IsNullOrEmpty(source))
            {
                List<IEnumerable<string>> results = regex.Matches(source)
                                   ?.OfType<Match>()
                                   ?.Select(x => x?.Groups?.Cast<Group>())
                                   ?.ToList().Select(x => x.Skip(1).Select(z => z.Value.ToString())).Where(x => !string.IsNullOrEmpty(x.First()) && !string.IsNullOrEmpty(x.ElementAt(1))).ToList();

                return results;
            }

            return new List<IEnumerable<string>>();
        }

        public List<string> ExtractElementsToList(string source, Regex regex)
        {
            List<string> results = regex.Matches(source)
                                    ?.Cast<Match>()
                                    ?.Select(m => m?.Groups?.Cast<Group>()?.ElementAtOrDefault(1)?.Value?.ToString()?.Trim()?.Replace(" ", ""))
                                    ?.ToList();

            return results;
        }


        public HttpWebRequest CreateWebRequest(string url)
        {
            return (HttpWebRequest)WebRequest.Create(url);
        }

        public HttpWebResponse GetResponse(HttpWebRequest request, string postData = null)
        {
            if (request.Method.ToUpper().Equals("POST"))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }

            return (HttpWebResponse)request.GetResponse();
        }

        public string ExtractString(string input, Regex regex)
        {
            return regex.Matches(input).Cast<Match>()?.FirstOrDefault()?.Groups?.Cast<Group>()?.ElementAtOrDefault(1)?.ToString();
        }
    }
}
