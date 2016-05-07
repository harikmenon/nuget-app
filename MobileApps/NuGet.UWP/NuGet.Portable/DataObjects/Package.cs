using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable
{
    public class Version
    {
        public string version { get; set; }
        public int downloads { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }

        public string registration { get; set; }

        public string description { get; set; }

        public string summary { get; set; }

        public string title { get; set; }

        public string iconUrl { get; set; }

        public string licenseUrl { get; set; }

        public string projectUrl { get; set; }

        public List<string> tags { get; set; }

        public List<string> authors { get; set; }

        public int totalDownloads { get; set; }

        public string version { get; set; }

        public List<Version> versions { get; set; }
    }

    public class RootObject
    {
        public int totalHits { get; set; }
        public string lastReopen { get; set; }
        public string index { get; set; }
        public List<Datum> data { get; set; }
    }
}
