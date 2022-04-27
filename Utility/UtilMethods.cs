using System;
using RestSharp;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using BravvoxAPITesting.DTOs;

namespace BravvoxAPITesting.Utility
{
    public class UtilMethods
    {
        public static string Serialize(dynamic payload)
        {
            return JsonConvert.SerializeObject(payload);

        }
        public static T ParseJson<T>(string file) //Taking string file and parse it to JSON - return object after deserialize
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }
        public string UrlPath()
        {
            var utility = ParseJson<UtilityDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\Utility.json");
            var baseUrlPath = utility.BaseUrl;
            return baseUrlPath;
        }
        public string TokenFilePath()
        {
            var utility = ParseJson<UtilityDTO>(@"C:\\Users\\Purva\\C#\\BravvoxAPITesting\\TestData\\Utility.json");
            var tokenFilePath = utility.TextFile;
            return tokenFilePath;
        }

    }
}
