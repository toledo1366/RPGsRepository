using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RPGsRepo.Core.Models;

namespace RPGsRepo.Core.Services
{
    public interface IDnDService
    {
        List<DnDClass> GetAllClasses(string url);
        DnDClass GetClass(string url);
        List<DnDRaces> GetAllRaces(string url);
        DnDRaces GetRace(string url);
    }
}
