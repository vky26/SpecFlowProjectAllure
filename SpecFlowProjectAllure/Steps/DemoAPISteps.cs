using System;
using TechTalk.SpecFlow;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using NUnit.Framework;
using System.IO;
using SpecFlowProjectAllure.Hooks;
using SpecFlowProjectAllure.Pojo;

namespace SpecFlowProjectAllure.Steps
{
    [Binding]
    public class DemoAPISteps
    {
        APIBase apiBase = new APIBase();
        GoogleAPIPOJO pojo;

        private String  apiToken = "";
        RestClient restClient = new RestClient("https://rahulshettyacademy.com/maps/api/place/");

        [Given(@"I get the login token")]
        public void GivenISendAPOSTRequest()
        {
            var queryString = "add/json";
            IRestRequest restRequest = new RestRequest(Method.POST);
            restRequest.AddParameter("key", "qaclick123");
            restRequest.Resource= queryString;
            restRequest.AddHeader("Content-Type", "application/json");

            String jsonPostBodyString = "";

            using (StreamReader str = new StreamReader("C:/Users/vignesh.parameswari/source/repos/SpecFlowProject/SpecFlowProject/Data/postbody.json"))
            {
                jsonPostBodyString = str.ReadToEnd();
            }

            restRequest.AddJsonBody(jsonPostBodyString);

            IRestResponse restResponse = restClient.Execute(restRequest);

            //Extract status code from received response and store in an Interger
            int StatusCode = (int)restResponse.StatusCode;
            System.Console.WriteLine("Status " + StatusCode);
            //Assert that correct Status is returned
            Assert.AreEqual(200, StatusCode, "Status code is not 200");
            GoogleAPIPOJO addPojo;
            addPojo = apiBase.Deserialize<GoogleAPIPOJO>(restResponse);//Deserialise the response by passing the pojo call reference

            System.Console.WriteLine("placeID " + addPojo.placeID);
            System.Console.WriteLine("status " + addPojo.status);
            apiToken = addPojo.placeID;
        }


        [Then(@"I get the place details")]
        public void ThenIGetThePlaceDetails()
        {
            Console.WriteLine(apiToken + " is the api token value to be used for place_id in all request"); //Get the token from background and use it

            //Get place details request - http://rahulshettyacademy.com/maps/api/place/get/json?place_id=452e90c3ab0563558629d2cc40f6173c&key=qaclick123

            var queryStringGet = "get/json";
            IRestRequest restRequest = new RestRequest(Method.GET);
            restRequest.AddParameter("place_id", apiToken);
            restRequest.AddParameter("key", "qaclick123");
            restRequest.Resource = queryStringGet;
            restRequest.AddHeader("Content-Type", "application/json");

         
            IRestResponse restResponse = restClient.Execute(restRequest);

            //Extract status code from received response and store in an Interger
            int StatusCode = (int)restResponse.StatusCode;
            System.Console.WriteLine("Status " + StatusCode);
            //Assert that correct Status is returned
            Assert.AreEqual(200, StatusCode, "Status code is not 200");


            pojo = apiBase.Deserialize<GoogleAPIPOJO>(restResponse);//Deserialise the response by passing the pojo call reference

            Console.WriteLine("Name from the Get request -->" + pojo.name);
            Console.WriteLine("Address from the Get request -->" + pojo.address);

        }

        [Then(@"I update the place details")]
        public void ThenIUpdateThePlaceDetails()
        {
            Console.WriteLine(apiToken + " is the api token value to be used for place_id in all request"); //Get the token from background and use it
                                                                                                            //Update request - https://rahulshettyacademy.com/maps/api/place/update/json?place_id=efcedc7e3fb347387d487332f66cd9c5&key=qaclick123

            var queryStringGet = "update/json";
            IRestRequest restRequest = new RestRequest(Method.PUT);
            restRequest.AddParameter("place_id", apiToken);
            restRequest.AddParameter("key", "qaclick123");
            restRequest.Resource = queryStringGet;
            restRequest.AddHeader("Content-Type", "application/json");

            String jsonBody = "{\"place_id\":\"" + apiToken +"\",\"address\":\"70 winter walk, USA\",\"key\":\"qaclick123\"}";
            restRequest.AddJsonBody(jsonBody);

            IRestResponse restResponse = restClient.Execute(restRequest);

            //Extract status code from received response and store in an Interger
            int StatusCode = (int)restResponse.StatusCode;
            System.Console.WriteLine("Status " + StatusCode);
            //Assert that correct Status is returned
            Assert.AreEqual(200, StatusCode, "Status code is not 200");
       
            pojo = apiBase.Deserialize<GoogleAPIPOJO>(restResponse);//Deserialise the response by passing the pojo call reference

            Console.WriteLine("Message -->" + pojo.msg);

        }

        [Then(@"I delete the place")]
        public void ThenIDeleteThePlace()
        {
            Console.WriteLine(apiToken + " is the api token value to be used for place_id in all request");
            //https://rahulshettyacademy.com/maps/api/place/delete/json?key=qaclick123
            var queryStringGet = "delete/json";
            IRestRequest restRequest = new RestRequest(Method.DELETE);
            restRequest.AddParameter("key", "qaclick123");
            restRequest.Resource = queryStringGet;
            restRequest.AddHeader("Content-Type", "application/json");

            String jsonBody = "{\"place_id\":\"" + apiToken + "\"}";
            restRequest.AddJsonBody(jsonBody);

            IRestResponse restResponse = restClient.Execute(restRequest);

            //Extract status code from received response and store in an Interger
            int StatusCode = (int)restResponse.StatusCode;
            System.Console.WriteLine("Status " + StatusCode);
            //Assert that correct Status is returned
            Assert.AreEqual(200, StatusCode, "Status code is not 200");

            pojo = apiBase.Deserialize<GoogleAPIPOJO>(restResponse);//Deserialise the response by passing the pojo call reference

            Console.WriteLine("status -->" + pojo.status);
            Console.WriteLine("status -->" + pojo.msg);

        }



    }
}
