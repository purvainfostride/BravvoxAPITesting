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
        public void GetEventDetails()
        {           var createEvent = new BravvoxGetAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.GettingEventDetails();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
    }
}
