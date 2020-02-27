using NginxCSharp;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //set up the base url for the api
                string baseUrl = "http://192.168.23.185:8080/api/4/";

                //create the http client
                var httpClient = new System.Net.Http.HttpClient();

                //authenticate if needed
                //var authByteArray = Encoding.ASCII.GetBytes($"admin:password"); 
                //var authString = Convert.ToBase64String(authByteArray);
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authString);

                //create the client
                var client = new Client(baseUrl, httpClient);

                //get the nginx object
                var niginx = GetNginx(client).ConfigureAwait(false).GetAwaiter().GetResult();

                //get the endoints
                var endpoints = GetEndpoints(client).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static async Task<ICollection<string>> GetEndpoints(Client client)
        {
            try
            {
                return await client.GetAPIEndpointsAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static async Task<NginxObject> GetNginx(Client client)
        {
            try
            {
                              
                return await client.GetNginxAsync("version,build,address,generation,load_timestamp,timestamp,pid,ppid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }


}
