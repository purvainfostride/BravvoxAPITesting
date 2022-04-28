using BravvoxAPITesting.DTOs;
using BravvoxAPITesting.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BravvoxAPITesting.BravvoxAPI
{
    public class BravvoxPostAPI<T>
    {

        public UserTokenDTO GeneratingToken()
        {
            var payload = UtilMethods.ParseJson<UserTokenDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\UserToken.json");
            var crudmethods = new CRUDMethods<UserTokenDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            UserTokenDTO content = crudmethods.GenerateToken(endp.UserTokenEndpoint, payload);
            return content;
        }
        public CreateEventDTO CreatingEvent()
        {
            var payload = UtilMethods.ParseJson<CreateEventDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\CreateEvent.json");
            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.CreateEvent(endp.CreateEventEndpoint, payload);
            return content;
        }

        public CreateEventDTO DeactivateEvent()
        {
            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.ActivateEvent(endp.DeactivateEventEndpoint);
            return content;
        }
        public CreateEventDTO ReactivateEvent()
        {

            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.ActivateEvent(endp.ReactivateEventEndpoint);
            return content;
        }
        public CreateEventDTO InvitingUserToEvent()
        {
            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.InviteUserToEvent(endp.InviteUserToEventEndpoint);
            return content;
        }
       
        public AddAdminToEventDTO AddingAdminToEvent()
        {
            var payload = UtilMethods.ParseJson<AddAdminToEventDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\AddAdminToEvent.json");
            var crudmethods = new CRUDMethods<AddAdminToEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.AddAdminToEvent(endp.AddAdminToEventEndpoint, payload);
            return content;
        }
        public AddAttendeeToEventDTO AddingAttendeeToEvent()
        {
            var payload = UtilMethods.ParseJson<AddAttendeeToEventDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\AddAttendeeToEvent.json");
            var crudmethods = new CRUDMethods<AddAttendeeToEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.AddAttendeeToEvent(endp.AddAttendeeToEventEndpoint, payload);
            return content;
        }
        public CreateEventDTO CancellingEvent()
        {
            var crudmethods = new CRUDMethods<CreateEventDTO>();
            var endp = UtilMethods.ParseJson<BravvoxAPIEndpointsDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\BravvoxAPIEndpoints.json");
            var content = crudmethods.CancelEvent(endp.CancelEventEndpoint);
            return content;
        }

    }
}