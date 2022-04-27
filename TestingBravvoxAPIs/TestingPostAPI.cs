using Microsoft.VisualStudio.TestTools.UnitTesting;
using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using BravvoxAPITesting.BravvoxAPI;
using System;
using RestSharp;

namespace BravvoxAPITesting.TestingBravvoxAPIs
{
    [TestClass]
    public class TestingPostAPI
    {        [TestMethod]
        public void ValidateCreateEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.CreatingEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        public void ValidateDeactivateEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.DeactivateEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        public void ValidateReactivateEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.ReactivateEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        public void ValidateAGenerateToken()
        {
            var createEvent= new BravvoxPostAPI<UserTokenDTO>();
            var apiHelper = new APIHelper<UserTokenDTO>();
            createEvent.GeneratingToken();
            //Assert.AreEqual(200, apiHelper.GetStatusCode());
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        public void ValidateInviteUserToEvent()
        {
            var createEvent = new BravvoxPostAPI<UserTokenDTO>();
            var apiHelper = new APIHelper<UserTokenDTO>();
            createEvent.InvitingUserToEvent();
            //Assert.AreEqual(200, apiHelper.GetStatusCode());
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
    }

}
