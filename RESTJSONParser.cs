using System;
using System.Net;
using System.Runtime.Serialization.Json;

namespace RESTServicesJSONParserExample

{
    class Program
    {
        static string BingMapsKey = "InsertYourBingMapsKeyHere"; 
        static void Main(string[] args)
        {           
            try
            {
                 string locationsRequest = CreateRequest("New%20York"); 
                Response locationsResponse = MakeRequest(locationsRequest);
                ProcessResponse(locationsResponse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }

        }
}
