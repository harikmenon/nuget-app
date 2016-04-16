using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable
{
    public class Package
    {
        public IEnumerable<string> Authors
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Owners
        {
            get;
            set;
        }

        public string ReleaseNotes
        {
            get;
            set;
        }

        public string Summary
        {
            get;
            set;
        }

        public string ProjectUrl
        {
            get;
            set;
        }

        public string IconUrl
        {
            get;
            set;
        }

        public string LicenseUrl
        {
            get;
            set;
        }
    }
}
