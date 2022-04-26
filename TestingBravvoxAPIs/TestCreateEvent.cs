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
        private string contentOfUsers;

        [TestMethod]
        public void ValidateCreateEvent()
        {
            var createEvent = new CreateEvent<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.CreatingEvent( contentOfUsers);
            Console.WriteLine(apiHelper.GetStatusDescription());
        }
        [TestMethod]
        public void ValidateAGenerateToken()
        {
            var createEvent= new CreateEvent<UserTokenDTO>();
            var apiHelper = new APIHelper<UserTokenDTO>();
            createEvent.GeneratingToken();
            Console.WriteLine(apiHelper.GetStatusDescription());

            //Assert.AreEqual(payload.Name, content.Name);
        }
    }

}
