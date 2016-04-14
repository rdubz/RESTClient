using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Dynamic;
using Newtonsoft.Json;

namespace RESTClient
{
    public class Controller
    {
        IRESTClient iREST;

        public Controller(IRESTClient restInterface)
        {
            //give the controller a reference to the interface so it has access to methods in the view (GUI)
            iREST = restInterface;

            //------- Register methods and events here, for the controller to handle. 
            iREST.GetRequest += HandleGetRequest;
            iREST.PutRequest += HandlePutRequest;
            iREST.PostRequest += HandlePostRequest;
            iREST.FireClearTextBox += HandleClearTextBox;
        }

        private HttpClient CreateClient(string domain)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);

            return client;
        }

        public async void  HandleGetRequest(string domainName)
        {
            using(HttpClient client = CreateClient(domainName))
            {
                dynamic data = new ExpandoObject();
                //TODO: Put the input into data to be serialized

                StringContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> task = client.PostAsync("/BoggleService.svc/users", content);

                HttpResponseMessage response = await task;

                if(response.IsSuccessStatusCode)
                {
                    iREST.Response = response.ToString();
                    iREST.StatusCode = response.StatusCode.ToString();
                }
                else
                {
                    iREST.StatusCode = response.StatusCode.ToString();
                }
            }

                //iREST.Response = "1";
        }

        public void HandlePutRequest(string domainName)
        {
            HttpClient client = CreateClient(domainName);
            iREST.Response = "2";
        }

        public void HandlePostRequest(string domainName)
        {
            HttpClient client = CreateClient(domainName);
            iREST.Response = "3";
        }

        public void HandleClearTextBox()
        {
            iREST.ClearTextBox();
        }
    }
}
