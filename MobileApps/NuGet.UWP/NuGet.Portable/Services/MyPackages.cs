using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable.Services
{
    public class MyPackages : IMyPackages
    {
        public IEnumerable<Package> GetMyPackages()
        {
            throw new NotImplementedException();
        }
    }
}
