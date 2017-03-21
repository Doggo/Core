﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Doggo
{
    public class RestRequest
    {
        public string Method { get; }
        public string Endpoint { get; }
        public Dictionary<string, object> Parameters { get; } = null;
        public string JsonBody { get; }

        public RestRequest(string method, string endpoint)
        {
            Method = method;
            Endpoint = endpoint;
        }

        public RestRequest(string method, string endpoint, Dictionary<string, object> parameters)
            : this(method, endpoint)
        {
            Parameters = parameters;
        }

        public RestRequest(string method, string endpoint, Dictionary<string, object> parameters, string body)
            : this(method, endpoint, parameters)
        {
            JsonBody = body;
        }

        public static string GetBodyString(object obj)
            => JsonConvert.SerializeObject(obj);

        public string GetParameterString()
        {
            if (Parameters == null)
                return "";

            List<string> paramList = new List<string>();
            foreach (var p in Parameters)
                if (p.Value != null) paramList.Add($"{p.Key}={p.Value}");
            return $"?{string.Join("&", paramList.ToArray())}";
        }
    }
}
