using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BravvoxAPITesting.BravvoxAPI
{
    public class BravvoxPatchAPI<T>
    {
        public CreateEventDTO UpdatingEvent()
        {
            var payload = UtilMethods.ParseJson<CreateEventDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\UpdateEvent.json");
            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.UpdateEvent(endp.UpdateEventEndpoint, payload);
            return content;
        }
    }
}
