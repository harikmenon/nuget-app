using MvvmCross.Core.ViewModels;
using NuGet.Portable.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Portable.ViewModels
{
    public class PackagesViewModel: MvxViewModel
    {

        public  ObservableCollection<Datum> PackageSet
        {
            get
            {
                if(packageSet==null)
                {
                    packageSet = new ObservableCollection<Datum>();
                }

                GetObservablePackages();
                return packageSet;
            }
        }

        readonly IPackages packages;
        ObservableCollection<Datum> packageSet;

        public PackagesViewModel(IPackages packages)
        {
            this.packages = packages;
        }

        public async void  GetObservablePackages()
        {
            var packages = await this.packages.GetMyPackages();
            foreach(var package in packages)
            {
                packageSet.Add(package);
            }

            RaisePropertyChanged("PackageSet");
        }

        public override void Start()
        {
            base.Start();
        }
    }
}
