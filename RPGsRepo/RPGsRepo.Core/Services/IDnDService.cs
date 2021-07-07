using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RPGsRepo.Core.Models;

namespace RPGsRepo.Core.Services
{
    public interface IDnDService
    {
        List<DnDClass> GetAllDnDClasses(string url);
        DnDClass GetDnDClass(string url);
    }
}
