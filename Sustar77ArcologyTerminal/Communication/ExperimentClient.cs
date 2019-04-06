using Sustar77ArcologyTerminal.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using RestSharp.Extensions.MonoHttp;
using System.Collections.Generic;

namespace Sustar77ArcologyTerminal.Communication
{
    public class ExperimentClient : IExperimentClient
    {
        private const string ServiceAddress = "http://arcology.prime.future-processing.com";
        User userData = new User();
        private List<string> actionsList = new List<string>();

        public ExperimentClient()
        {
            if (actionsList.Capacity == 0)
            {
                actionsList.Add(CreateImportFoodCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreateProduceCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreateBuildArcologyCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreateCleanCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreatePropagandaCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreateExpandPopulationCapacityCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreateExpandFoodCapacityCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreateWeAreReadyCommand(userData.getUserLogin(), userData.getUserToken()));
                actionsList.Add(CreateRestartCommand(userData.getUserLogin(), userData.getUserToken()));
            }
        }


        public Result Describe(string login, string token)
        {
            var encodedLogin = HttpUtility.UrlEncode(login);
            string baseUrl = $"{ServiceAddress}/describe?login={encodedLogin}&token={token}";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<Result>(response.Content);
        }

        public HttpStatusCode Execute(string command)
        {
            string baseUrl = $"{ServiceAddress}/execute";
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", command, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.StatusCode;
        }

        public HttpStatusCode Execute(string command, string parameter)
        {
            var client = new RestClient("http://arcology.prime.future-processing.com/execute");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "78a1dd7f-8cb6-6f4d-60dc-1e75a2885211");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", command + ", " + "\"Parameter\":\"" + parameter +"\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.StatusCode;
        }
        private static string CreateRestartCommand(string login, string token)
        {
            return "{\"Command\": \"restart\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreateProduceCommand(string login, string token)
        {
            return "{\"Command\": \"produce\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreateImportFoodCommand(string login, string token)
        {
            return "{\"Command\": \"importFood\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreatePropagandaCommand(string login, string token)
        {
            return "{\"Command\": \"propaganda\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreateCleanCommand(string login, string token)
        {
            return "{\"Command\": \"clean\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreateBuildArcologyCommand(string login, string token)
        {
            return "{\"Command\": \"buildArcology\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreateExpandPopulationCapacityCommand(string login, string token)
        {
            return "{\"Command\": \"expandPopulationCapacity\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreateExpandFoodCapacityCommand(string login, string token)
        {
            return "{\"Command\": \"expandFoodCapacity\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }
        private static string CreateWeAreReadyCommand(string login, string token)
        {
            return "{\"Command\": \"weAreReady\", \"Login\": \"" + login + "\", \"Token\": \"" + token + "\"";
        }

        public List<string> getActionList()
        {
            return actionsList;
        }

    }
}