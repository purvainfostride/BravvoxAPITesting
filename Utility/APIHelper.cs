using System;
using RestSharp;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace BravvoxAPITesting.Utility
{
    public class APIHelper<T>
    {
        public static RestClient restClient;
        public static RestRequest restRequest;
        public static IRestResponse restResponse;
        public string baseUrl = "https://qa.bravvox.com/";


        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            var RestClient = new RestClient(url);
            return RestClient;
        }
        public RestRequest CreatePostRequest(dynamic payload)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }
        public IRestResponse GetResponse(RestClient restClient, RestRequest restRequest)
        {  
            return restResponse = restClient.Execute(restRequest);    
        }
        public DTOs GetContent<DTOs>(IRestResponse response)
        {
            var contentOfUsers = response.Content;

            string jsonFormatted = JValue.Parse(contentOfUsers).ToString(Formatting.Indented);
            Console.WriteLine(jsonFormatted);
            DTOs dTOs = JsonConvert.DeserializeObject<DTOs>(contentOfUsers);
            return dTOs;
        }
        public HttpStatusCode GetStatusCode()
        {
            var statusCode = restResponse.StatusCode;
            Console.WriteLine("Status Code is: " + (int)statusCode);
            return statusCode;
        }
        public string GetStatusDescription()
        {
            var statusDescription = restResponse.StatusDescription;
            Console.WriteLine("StatusDescription is: " + statusDescription);
            return statusDescription;
        }
    }
}
