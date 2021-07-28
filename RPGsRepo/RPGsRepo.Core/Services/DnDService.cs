using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RPGsRepo.Core.Models;
using RPGsRepo.Core.Services;

namespace RPGsRepo.Core.Services
{
    public class DnDService:IDnDService
    {
        readonly IRestClient _restClient;
        private IRestRequest _restRequest;

        public DnDService()
        {
            _restClient = new RestClient();
        }

        public List<DnDClass> GetAllClasses(string url)
        {
            _restRequest = new RestRequest(url);
            IRestResponse<List<DnDClass>> classesResponse = _restClient.Get<List<DnDClass>>(_restRequest);
            if (classesResponse.IsSuccessful)
            {
                return (List<DnDClass>)classesResponse;
            }
            return null;
        }

        public List<DnDRaces> GetAllRaces(string url)
        {
            _restRequest = new RestRequest(url);
            IRestResponse<List<DnDRaces>> racesResponse = _restClient.Get<List<DnDRaces>>(_restRequest);
            if (racesResponse.IsSuccessful)
            {
                return (List<DnDRaces>)racesResponse;
            }
            return null;
        }

        public DnDClass GetClass(string url)
        {
            _restRequest = new RestRequest(url);
            IRestResponse<DnDClass> classResponse = _restClient.Get<DnDClass>(_restRequest);
            if (classResponse.IsSuccessful)
            {
                return (DnDClass)classResponse;
            }
            return null;
        }

        public DnDRaces GetRace(string url)
        {
            _restRequest = new RestRequest(url);
            IRestResponse<DnDRaces> raceResponse = _restClient.Get<DnDRaces>(_restRequest);
            if (raceResponse.IsSuccessful)
            {
                return (DnDRaces)raceResponse;
            }
            return null;
        }
    }
}
