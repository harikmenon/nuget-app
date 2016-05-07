using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable.Services
{
    public interface IMyPackages
    {
       IEnumerable<Datum> GetMyPackages();
    }
}
