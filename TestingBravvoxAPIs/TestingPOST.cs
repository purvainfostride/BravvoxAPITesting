using Microsoft.VisualStudio.TestTools.UnitTesting;
using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using BravvoxAPITesting.BravvoxAPI;
using System;
using RestSharp;

namespace BravvoxAPITesting.TestingBravvoxAPIs
{
    [TestClass]
    public class TestingPOST
    {   [TestMethod]
        [Priority(2)]
        public void ValidateCreateEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.CreatingEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        [Priority(6)]
        public void ValidateDeactivateEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.DeactivateEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        [Priority(7)]
        public void ValidateReactivateEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.ReactivateEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        [Priority(5)]
        public void ValidateInvitingUserToEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.ReactivateEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        [Priority(4)]
        public void ValidateAddAdminToEvent()
        {
            var createEvent = new BravvoxPostAPI<AddAdminToEventDTO>();
            var apiHelper = new APIHelper<UserTokenDTO>();
            createEvent.AddingAdminToEvent();
            //Assert.AreEqual(200, apiHelper.GetStatusCode());
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        [Priority(3)]
        public void ValidateAddAttendeeToEvent()
        {
            var createEvent = new BravvoxPostAPI<AddAttendeeToEventDTO>();
            var apiHelper = new APIHelper<UserTokenDTO>();
            createEvent.AddingAttendeeToEvent();
            //Assert.AreEqual(200, apiHelper.GetStatusCode());
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        [Priority(1)]
        public void ValidateAGenerateToken()
        {
            var createEvent= new BravvoxPostAPI<UserTokenDTO>();
            var apiHelper = new APIHelper<UserTokenDTO>();
            createEvent.GeneratingToken();
            //Assert.AreEqual(200, apiHelper.GetStatusCode());
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        [Priority(8)]
        public void ValidateCancelEvent()
        {
            var createEvent = new BravvoxPostAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.CancellingEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
    }

}
