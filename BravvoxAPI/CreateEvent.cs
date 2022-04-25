using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BravvoxAPITesting.BravvoxAPI
{
    public class CreateEvent<T>
    {
        //public void CreatingEvent()
        //{
        //    var payload = HandleContent.ParseJson<CreateEventDTO>("CreateUser.json");
        //    var crudmethods = new CRUDMethods<CreateEventDTO>();
        //    var endp = HandleContent.ParseJson<BravvoxAPIsDTO>("BravvoxAPIs.json");
        //    var content = crudmethods.CreateUsers(endp.CreateEventApi, payload);
        //    Console.WriteLine(content);
        //}
        
        public UserTokenDTO GeneratingToken()
        {
            var payload = HandleContent.ParseJson<UserTokenDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\UserToken.json");
            var crudmethods = new CRUDMethods<UserTokenDTO>();
            UserTokenDTO content = crudmethods.GenerateToken("services/auth/v1/login", payload);
           
            return content;
        }

    }
}
