using System;
using MvvmCross;
using MvvmCross.ViewModels;
using RPGsRepository.Core.Services;
using RPGsRepository.Core.ViewModels;

namespace RPGsRepository.Core
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
