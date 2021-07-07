using System;
using MvvmCross;
using MvvmCross.ViewModels;
using RPGsRepo.Core.Services;
using RPGsRepo.Core.ViewModels;

namespace RPGsRepo.Core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IDnDService, DnDService>();

            RegisterAppStart<StartupViewModel>();
        }
    }
}
