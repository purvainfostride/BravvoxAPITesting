﻿using System;
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

            return dTOs;
        }
        //public string GetToken(IRestResponse response)
        //{

        //    JObject o = JObject.Parse(response.Content);
        //    string token = o["data"]["token"].ToString();
        //    Console.WriteLine(token);
        //    return token;
        //}
        public RestRequest CreateEventPostRequest(dynamic payload, string contentOfUsers)
        {
            var restRequest = new RestRequest(Method.POST);
            Console.WriteLine(contentOfUsers);
            restRequest.AddHeader("Authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkb2N1bWVudElEIjoiYzhldnNyZGtoNGRvNzIyamJzZTAiLCJ1c2VybmFtZSI6Ik1pa2UiLCJyb2xlIjoiIiwibmFtZSI6Ik1pa2UiLCJlbWFpbCI6ImphZ2FucHJlZXQuc2luZ2grMDEyQGJyYXZ2b3guY29tIiwicGhvbmUiOiIiLCJpc0FkbWluIjpmYWxzZSwiaXNDb250ZW50Q3JlYXRvciI6ZmFsc2UsImlzVmVyaWZpZWQiOnRydWUsInN0YXR1cyI6ImFjdGl2ZSIsImluZmx1ZW5jZXJTdGF0dXMiOmZhbHNlLCJleHAiOjE2NTA5ODgyMzUsImlhdCI6MTY1MDk3MDIzNSwiaXNzIjoiQnJhdnZveCJ9.WCgzcCvzkejP1u0f9MSKlZevuibcoYCpA6b6K_aPIdA");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
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
