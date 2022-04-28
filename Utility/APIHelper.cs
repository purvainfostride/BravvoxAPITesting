namespace BravvoxAPITesting.Utility
{
    using System;
    using RestSharp;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using BravvoxAPITesting.DTOs;

    public class APIHelper<T>
    {
        public static RestClient restClient;
        public static RestRequest restRequest;
        public static IRestResponse restResponse;

        UtilMethods utilMethods = new UtilMethods();

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(utilMethods.UrlPath(), endpoint);
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
            File.WriteAllText(utilMethods.TokenFilePath(), token);
            return dTOs;
        }
        public DTOs GetEventContent<DTOs>(IRestResponse response)
        {
            var contentOfUsers = response.Content;
            Console.WriteLine(contentOfUsers);
            string jsonFormatted = JValue.Parse(contentOfUsers).ToString(Formatting.Indented);
            Console.WriteLine(jsonFormatted);
            DTOs dTOs = JsonConvert.DeserializeObject<DTOs>(contentOfUsers);
            return dTOs;
        }

        public RestRequest EventPostRequest(dynamic payload)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Authorization", File.ReadAllText(utilMethods.TokenFilePath()));
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }
        public RestRequest ActivateEventPostRequest()
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Authorization", File.ReadAllText(utilMethods.TokenFilePath()));
            return restRequest;
        }
        public RestRequest InvitePostRequest()
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Authorization", File.ReadAllText(utilMethods.TokenFilePath()));
            return restRequest;
        }
        
        public RestRequest EventGetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Authorization", File.ReadAllText(utilMethods.TokenFilePath()));
            return restRequest;
        }
        public RestRequest AttendeeListGetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Authorization", File.ReadAllText(utilMethods.TokenFilePath()));
            return restRequest;
        }
        
        public RestRequest EventPacthRequest(dynamic payload)
        {
            var restRequest = new RestRequest(Method.PATCH);
            restRequest.AddHeader("Authorization", File.ReadAllText(utilMethods.TokenFilePath()));
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }
        public RestRequest AddAdminToEventPostRequest(dynamic payload)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Authorization", File.ReadAllText(utilMethods.TokenFilePath()));
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
