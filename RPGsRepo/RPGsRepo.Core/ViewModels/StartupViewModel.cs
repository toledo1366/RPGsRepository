using System;
using MvvmCross.ViewModels;
using RPGsRepo.Core.Helpers;
using RPGsRepo.Core.Services;

namespace RPGsRepo.Core.ViewModels
{
    public class StartupViewModel:MvxViewModel
    {
        readonly IDnDService _dndService;
        public StartupViewModel()
        {
            _dndService.GetAllDnDClasses(Constants.DnDApiBaseURL + "classes/barbarian");
        }
    }
}
