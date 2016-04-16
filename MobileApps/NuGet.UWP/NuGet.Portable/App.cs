using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using NuGet.Portable.Services;
using NuGet.Portable.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable
{
    public class App: MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IMyPackages, MyPackages>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MyPackagesViewModel>());
        }
    }
}
