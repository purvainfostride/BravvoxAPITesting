using BravvoxAPITesting.DTOs;
using System;
using RestSharp;
using System.IO;
using Newtonsoft.Json;
using System.Net;
namespace BravvoxAPITesting.Utility
{
    public class CRUDMethods<T>
    {
        public CreateEventDTO CreateEvent(string endpoint, dynamic payload)
        {
            var user = new APIHelper<CreateEventDTO>();
            var url = user.SetUrl(endpoint);     
            var requestJson = HandleContent.Serialize(payload);//serialize into json
            var request = user.CreatePostRequest(requestJson);
            var response = user.GetResponse(url, request);
            CreateEventDTO content = user.GetContent<CreateEventDTO>(response);
            return content;
        }
        public UserTokenDTO GenerateToken(string endpoint, dynamic payload)
        {
            var user = new APIHelper<UserTokenDTO>();
            var url = user.SetUrl(endpoint);
            var requestJson = HandleContent.Serialize(payload);//serialize into json
            var request = user.CreatePostRequest(requestJson);
            var response = user.GetResponse(url, request);
            UserTokenDTO content = user.GetContent<UserTokenDTO>(response);

            return content;

        }
    }
}
