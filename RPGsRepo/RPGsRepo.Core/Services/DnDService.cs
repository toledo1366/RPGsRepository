using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RPGsRepository.Core.Models;

namespace RPGsRepository.Core.Services
{
    public class DnDService:IDnDService
    {
        readonly IRestClient _restClient;
        private IRestRequest _restRequest;

        public DnDService()
        {
            _restClient = new RestClient();
        }

        public List<DnDClass> GetAllDnDClasses(string url)
        {
            _restRequest = new RestRequest(url);
            IRestResponse<List<DnDClass>> classesResponse = _restClient.Get<List<DnDClass>>(_restRequest);
            if (classesResponse.IsSuccessful)
            {
                return (List<DnDClass>)classesResponse;
            }
            return null;
        }

        public DnDClass GetDnDClass(string url)
        {
            _restRequest = new RestRequest(url);
            IRestResponse<DnDClass> classResponse = _restClient.Get<DnDClass>(_restRequest);
            if (classResponse.IsSuccessful)
            {
                return (DnDClass)classResponse;
            }
            return null;
        }
    }
}
