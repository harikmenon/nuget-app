using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable.Utilities
{
    class UrlBuilder
    {

        public static string GetQuery(string baseUrl, Dictionary<string, string> values, bool omitEmpty)
        {

            var builder = new UriBuilder(baseUrl);

            if(!omitEmpty)
            {
                builder.Query = string.Join("&", values.Keys.Select(key => string.Format("{0}={1}", WebUtility.UrlEncode(key), WebUtility.UrlEncode(values[key]))));
                return builder.ToString();
            }

            builder.Query = string.Join("&", values.Keys.Where(key => !string.IsNullOrWhiteSpace(values[key])).Select(key => string.Format("{0}={1}", WebUtility.UrlEncode(key), WebUtility.UrlEncode(values[key]))));
            return builder.ToString();
        }
    }
}
