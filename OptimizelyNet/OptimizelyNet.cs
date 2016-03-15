using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OptimizelyNet.DTO;
using RestSharp;
using RestSharp.Extensions;

namespace OptimizelyNet
{
    public class OptimizelyNet
    {
        private const string BaseUrl = "https://www.optimizelyapis.com";
        private const string ApiVersion = "v1";
        private readonly string _apiToken;

        public OptimizelyNet(string apiToken)
        {
            _apiToken = apiToken;
        }

        private T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(BaseUrl);
            client.AddDefaultHeader("token", _apiToken);
            client.AddDefaultParameter("ApiVersion", ApiVersion, ParameterType.UrlSegment);
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error retrieving response - see inner exception for more details.", response.ErrorException);
            }

            return response.Data;
        }

        public List<Project> GetProjects()
        {
            var request = new RestRequest("experiment/{ApiVersion}/projects/");
            return Execute<List<Project>>(request);
        }
    }
}
