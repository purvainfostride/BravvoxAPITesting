using System;
using RestSharp;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace BravvoxAPITesting.Utility
{
    public class HandleContent
    {

        public static string Serialize(dynamic payload)
        {
            return JsonConvert.SerializeObject(payload);

        }
        public static T ParseJson<T>(string file) //Taking string file and parse it to JSON - return object after deserialize
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }
    }
}
