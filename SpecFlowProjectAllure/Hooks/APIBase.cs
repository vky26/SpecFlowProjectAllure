using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProjectAllure.Hooks
{
    class APIBase
    {
        public T Deserialize<T>(IRestResponse response)
        {
            JsonDeserializer jsonDeserializer = new JsonDeserializer();
            return jsonDeserializer.Deserialize<T>(response);
        }
    }
}
