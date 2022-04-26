using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BravvoxAPITesting.BravvoxAPI
{
    public class CreateEvent<T>
    {

        public void CreatingEvent(string contentOfUsers)
        {
            var payload = HandleContent.ParseJson<CreateEventDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\CreateEvent.json");
            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = HandleContent.ParseJson<BravvoxAPIsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIs.json");
            var content = crudmethods.CreateEvent(endp.CreateEventApi, payload, contentOfUsers);
            Console.WriteLine(content);
        }

        public UserTokenDTO GeneratingToken()
        {
            var payload = HandleContent.ParseJson<UserTokenDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\UserToken.json");
            var crudmethods = new CRUDMethods<UserTokenDTO>();
            var endp = HandleContent.ParseJson<BravvoxAPIsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIs.json");
            UserTokenDTO content = crudmethods.GenerateToken(endp.UserTokenAPI, payload);   
            return content;
        }

    }
}
