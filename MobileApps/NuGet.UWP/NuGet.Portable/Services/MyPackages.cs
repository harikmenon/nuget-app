using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable.Services
{
    public class MyPackages : IMyPackages
    {
        public MyPackages()
        {


        }

        public IEnumerable<Datum> GetMyPackages()
        {

            return null;
        }
    }
}
