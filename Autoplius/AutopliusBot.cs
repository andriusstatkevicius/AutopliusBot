using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using static System.Console;

namespace AutopliusCrawler
{
    internal class AutopliusBot
    {
        internal Crawler crawler;
        private const string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36";
        internal int mileageTo;
        internal int mileageFrom;
        internal int yearFrom;
        internal int yearTo;
        internal int olderNot;
        internal int countryID;
        internal int cityID;
        internal string searchedCity;
        internal int priceTo;
        internal int priceFrom;
        private static string referer;
        internal string searchedNumber;
        internal static List<string> urlsWithNumber;

        public void CollectData()
        {
            urlsWithNumber = new List<string>();
            int pageNumber = 0;
            bool loadNext = true;

            while (loadNext)
            {
                string paramsToAdd = ConstructParams(pageNumber);
                string advertisementsSource = LoadAdvertisements(paramsToAdd, pageNumber);

                if (string.IsNullOrEmpty(advertisementsSource))
                {
                    continue;
                }

                loadNext = Regexes.NextPage.IsMatch(advertisementsSource);
                pageNumber++;

                List<string> urlsToLoad = crawler.ExtractElementsToList(advertisementsSource, Regexes.UrlsToLoad);

                if (!urlsToLoad.Any())
                {
                    continue;
                }

                foreach (string url in urlsToLoad)
                {
                    Thread.Sleep(2000);

                    string advertisement = LoadAdvertisement(url);

                    if (string.IsNullOrEmpty(advertisement))
                    {
                        referer = string.Empty;
                        --pageNumber;
                        loadNext = true;
                        break;
                    }

                    List<string> phoneNumbers = crawler.ExtractElementsToList(advertisement, Regexes.PhoneNumbers);
                    if (!phoneNumbers.Any())
                    {
                        continue;
                    }

                    string announcementDescription = crawler.ExtractString(advertisement, Regexes.AnnouncementDescription);

                    if (!string.IsNullOrEmpty(announcementDescription))
                    {
                        List<string> numbersFromDescription = crawler.ExtractElementsToList(announcementDescription, Regexes.PhoneNumbers2);
                        if (numbersFromDescription.Any())
                        {
                            phoneNumbers.AddRange(numbersFromDescription);
                        }
                    }

                    if (phoneNumbers.Any(x => x.Contains(searchedNumber)))
                    {
                        urlsWithNumber.Add(url);
                    }
                }
            }

            Console.ReadKey();
        }

        internal bool CollectCityIDs(string url)
        {
            var request = crawler.CreateWebRequest(url);
            request.Method = "POST";
            request.Host = Urls.Host;
            request.KeepAlive = true;
            request.Headers.Add("Upgrade-Insecure-Requests", "1");
            request.UserAgent = UserAgent;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3";
            request.Headers.Add("Accept-Language", "en-GB,en;q=0.9");

            string postData = "parent_id=1&target_id=fk_place_cities_id&project=autoplius&category_id=2&type=search&my_anns=false&__block=ann_ajax_0_plius&__opcode=ajaxGetChildsTo";

            try
            {
                HttpWebResponse response = crawler.GetResponse(request, postData);
                string searchPage = response.ToStringValue();

                searchPage = searchPage.Replace(@"\u0117", "ė").Replace(@"\u0160", "Š").Replace(@"\u017e", "ž").Replace(@"\u010d", "č").Replace(@"\u0173", "ų").Replace(@"\u0161", "š").Replace(@"\u016b", "ū");

                List<IEnumerable<string>> result = crawler.ExtractElementsToIEnumerableList(searchPage, Regexes.CityIDs);

                result.ForEach(x =>
                {
                    if (!Dictionaries.CityToID.ContainsKey(x.ElementAtOrDefault(1)) && int.TryParse(x.ElementAtOrDefault(0), out int cityID))
                    {
                        Dictionaries.CityToID[x.ElementAtOrDefault(1).ToUpper()] = cityID;
                    }
                });

                return true;
            }
            catch
            {
                return false;
            }
        }

        private string LoadAdvertisement(string url)
        {
            HttpWebRequest request = crawler.CreateWebRequest(url);

            request.Host = Urls.Host;
            request.KeepAlive = true;
            request.Headers.Add("Upgrade-Insecure-Requests", "1");
            request.UserAgent = UserAgent;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3";
            request.Referer = AutopliusBot.referer;
            request.Headers.Add("Accept-Language", "en-GB,en;q=0.9");

            request.Method = "GET";

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                WriteLine(url + " " + response?.StatusCode);
                return response.ToStringValue();
            }
            catch
            {
                return string.Empty;
            }
        }

        private string LoadAdvertisements(string paramsToAdd, int pageNumber)
        {
            string url = $@"{Urls.Ads}?{paramsToAdd}";

            HttpWebRequest request = crawler.CreateWebRequest(url);

            request.KeepAlive = true;
            request.Headers.Add("Upgrade-Insecure-Requests", "1");
            request.UserAgent = UserAgent;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3";

            if(!string.IsNullOrEmpty(referer))
            {
                request.Referer = pageNumber == 1 ? Urls.SearchPage : referer;
            }

            request.Headers.Add("Accept-Language", "en-GB,en;q=0.9");
            request.Method = "GET";

            try
            {
                HttpWebResponse response = crawler.GetResponse(request);
                WriteLine(url + " " + response.StatusCode);
                referer = response?.GetPageUrl();
                return response.ToStringValue();
            }
            catch
            {
                return string.Empty;
            }
        }

        private string ConstructParams(int pageNumber)
        {
            List<string> requestParams = new List<string>()
            {
                "make_id_list=",
                "engine_capacity_from=",
                "engine_capacity_to=",
                "power_from=",
                "power_to=",
                $"kilometrage_from={(mileageFrom == 0? string.Empty : mileageFrom.ToString())}",
                $"kilometrage_to={(mileageTo == 0? string.Empty : mileageTo.ToString())}",
                "has_damaged_id=",
                "color_id=",
                "condition_type_id=",
                $"make_date_from={(yearFrom == 0 ? string.Empty : yearFrom.ToString())}",
                $"make_date_to={(yearTo == 0 ? string.Empty : yearTo.ToString())}",
                $"sell_price_from={(priceFrom == 0 ? string.Empty : priceFrom.ToString())}",
                $"sell_price_to={(priceTo == 0? string.Empty : priceTo.ToString())}",
                "fuel_id=",
                "gearbox_id=",
                "body_type_id=",
                "wheel_drive_id=",
                "number_of_seats_id=",
                "number_of_doors_id=",
                $"fk_place_countries_id={countryID}",
                $"fk_place_cities_id={cityID}",
                "steering_wheel_id=",
                "origin_country_id=",
                $"older_not={(olderNot == 0? string.Empty : olderNot.ToString())}",
                "qt=",
                "order_by=2",
                "order_direction=ASC"
            };

            if (pageNumber > 1)
            {
                requestParams.Add($"page_nr={pageNumber}");
            }

            return string.Join("&", requestParams);
        }
    }
}
