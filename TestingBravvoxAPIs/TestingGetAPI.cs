using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using BravvoxAPITesting.BravvoxAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BravvoxAPITesting.TestingBravvoxAPIs
{
    [TestClass]
    public class TestingGetAPI
    {
        [TestMethod]
        public void ValidateGetEventDetails()
        {   var createEvent = new BravvoxGetAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.GettingEventDetails();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
        [TestMethod]
        public void ValidateGetAttendeeList()
        {
            var createEvent = new BravvoxGetAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.GettingAttendeeList();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
    }
}
