using MvvmCross.Core.ViewModels;
using MvvmCross.WindowsUWP.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace NuGet.UWP
{
    class Setup: MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new NuGet.Portable.App();
        }
    }
}
