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
        public CreateEventDTO CreateEvent(string endpoint, dynamic payload)
        {
            var user = new APIHelper<CreateEventDTO>();
            var url = user.SetUrl(endpoint);     
            var requestJson = HandleContent.Serialize(payload);//serialize into json
            var request = user.EventPostRequest(requestJson);
            var response = user.GetResponse(url, request);
            CreateEventDTO content = user.GetEventContent<CreateEventDTO>(response);
            return content;
        }
        public CreateEventDTO ActivateEvent(string endpoint)
        {
            var user = new APIHelper<CreateEventDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.ActivateEventPostRequest();
            var response = user.GetResponse(url, request);
            CreateEventDTO content = user.GetEventContent<CreateEventDTO>(response);
            return content;
        }
        public CreateEventDTO InviteUserToEvent(string endpoint)
        {
            var user = new APIHelper<CreateEventDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.InvitePostRequest();
            var response = user.GetResponse(url, request);
            CreateEventDTO content = user.GetEventContent<CreateEventDTO>(response);
            return content;
        }
        public CreateEventDTO GetEventDetails(string endpoint)
        {
            var user = new APIHelper<CreateEventDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.EventGetRequest();
            var response = user.GetResponse(url, request);
            CreateEventDTO content = user.GetEventContent<CreateEventDTO>(response);
            return content;
        }
        public CreateEventDTO UpdateEvent(string endpoint, dynamic payload)
        {
            var user = new APIHelper<CreateEventDTO>();
            var url = user.SetUrl(endpoint);
            var requestJson = HandleContent.Serialize(payload);//serialize into json
            var request = user.EventPacthRequest(requestJson);
            var response = user.GetResponse(url, request);
            CreateEventDTO content = user.GetEventContent<CreateEventDTO>(response);
            return content;
        }
    }
}
