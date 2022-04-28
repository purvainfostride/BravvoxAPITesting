using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BravvoxAPITesting.BravvoxAPI
{
    public class BravvoxGetAPI<T>
    {
        public CreateEventDTO GettingEventDetails()
        {
            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.GetEventDetails(endp.GetEventDetailsEndpoint);
            return content;
        }
        public AddAttendeeToEventDTO GettingAttendeeList()
        {
            var crudmethods = new CRUDMethods<AddAttendeeToEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.GetAttendeeList(endp.GetAttendeeListEndpoint);
            return content;
        }

    }
}
