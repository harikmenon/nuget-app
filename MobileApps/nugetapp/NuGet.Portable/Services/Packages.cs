using Newtonsoft.Json;
using NuGet.Portable.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable.Services
{
    public class Packages : IPackages
    {
        public Packages()
        {


        }

        public async Task<IEnumerable<Datum>> GetMyPackages()
        {
            HttpClient client = new HttpClient();
            var uri = "https://api-v3search-0.nuget.org/query?";
            Dictionary<string, string> parameters = new Dictionary<string, string>()
            {
                {"q", "" },
                {"skip", "0"},
                {"take", "26"},
                {"prerelease",  "true"},
                { "supportedFramework",""}
            };

            using (HttpResponseMessage response = await client.GetAsync(UrlBuilder.GetQuery(uri, parameters, false)))
            using (HttpContent content = response.Content)
            {
                var result = JsonConvert.DeserializeObject<RootObject>(await content.ReadAsStringAsync());
                return result.data;
            }
        }
    }
}
