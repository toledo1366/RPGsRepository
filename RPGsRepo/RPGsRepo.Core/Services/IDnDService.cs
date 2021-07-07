using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RPGsRepository.Core.Models;

namespace RPGsRepository.Core.Services
{
    public interface IDnDService
    {
        List<DnDClass> GetAllDnDClasses(string url);
        DnDClass GetDnDClass(string url);
    }
}
