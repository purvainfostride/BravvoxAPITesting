using Microsoft.VisualStudio.TestTools.UnitTesting;
using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using BravvoxAPITesting.BravvoxAPI;

namespace BravvoxAPITesting.TestingBravvoxAPIs
{
    [TestClass]
    public class TestingPatchAPI
    {
        [TestMethod]
        public void ValidateUpdateEvent()
        {
            var createEvent = new BravvoxPatchAPI<CreateEventDTO>();
            var apiHelper = new APIHelper<CreateEventDTO>();
            createEvent.UpdatingEvent();
            Assert.AreEqual("OK", apiHelper.GetStatusDescription());
        }
    }
}
