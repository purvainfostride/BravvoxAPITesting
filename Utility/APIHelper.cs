using System;
using RestSharp;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace BravvoxAPITesting.Utility
{
    public class APIHelper<T>
    {
        public static RestClient restClient;
        public static RestRequest restRequest;
        public static IRestResponse restResponse;
        public string baseUrl = "https://qa.bravvox.com/";
        public string text = @"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\Token.txt";

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            var RestClient = new RestClient(url);
            return RestClient;
        }
        public RestRequest CreatePostRequest(dynamic payload)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Content-Type", "application/json");
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
            JObject o = JObject.Parse(response.Content);
            string token = o["data"]["token"].ToString();
            File.WriteAllText(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\Token.txt", token);
            return dTOs;
        }
        public DTOs GetEventContent<DTOs>(IRestResponse response)
        {
            var contentOfUsers = response.Content;
            string jsonFormatted = JValue.Parse(contentOfUsers).ToString(Formatting.Indented);
            Console.WriteLine(jsonFormatted);
            DTOs dTOs = JsonConvert.DeserializeObject<DTOs>(contentOfUsers);
            return dTOs;
        }
        public RestRequest EventPostRequest(dynamic payload)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Authorization", File.ReadAllText(text));
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }
        public RestRequest ActivateEventPostRequest()
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Authorization", File.ReadAllText(text));
            return restRequest;
        }
        public RestRequest EventPacthRequest(dynamic payload)
        {
            var restRequest = new RestRequest(Method.PATCH);
            restRequest.AddHeader("Authorization", File.ReadAllText(text));
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }
        //public int GetStatusCode(IRestResponse response)
        //{
        //    JObject o = JObject.Parse(response.Content);
        //    string statusCode = o["data"]["status"].ToString();
        //    int s= int.Parse(statusCode);
        //    return s;
        //}
        public string GetStatusDescription()
        {
            var statusDescription = restResponse.StatusDescription;
            return statusDescription;
        }
    }
}
