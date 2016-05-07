using MvvmCross.Core.ViewModels;
using NuGet.Portable.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable.ViewModels
{
    public class MyPackagesViewModel:MvxViewModel
    {
        public string Name
        {
            get;
            set;
        }

        readonly IMyPackages myPackages;

        public MyPackagesViewModel(IMyPackages myPackages)
        {
            this.myPackages = myPackages;
            Name = "Bazzinga";
        }

        public override void Start()
        {
            base.Start();
        }
    }
}
