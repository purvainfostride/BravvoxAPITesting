using Microsoft.VisualStudio.TestTools.UnitTesting;
using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using BravvoxAPITesting.BravvoxAPI;
using System;

namespace BravvoxAPITesting.TestingBravvoxAPIs
{
    [TestClass]
    public class TestCreateEvent
    {
      
        
        //public void ValidateCreateEvent()
        //{
        //    var payload = HandleContent.ParseJson<CreateEventDTO>("CreateUser.json");
        //    var crudmethods = new CRUDMethods<CreateEventDTO>();
        //    var endp = HandleContent.ParseJson<BravvoxAPIsDTO>("BravvoxAPIs.json");
        //    var content = crudmethods.CreateEvent(endp.CreateEventApi, payload);
        //    Console.WriteLine(content);
        //    //Assert.AreEqual(payload.Name, content.Name);
        //}
        [TestMethod]
        public void ValidateGenerateToken()
        {
            var createEvent= new CreateEvent<UserTokenDTO>();
            createEvent.GeneratingToken();
            
          
            //Assert.AreEqual(payload.Name, content.Name);
        }
    }

}
