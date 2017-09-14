using iStoreApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace iStoreApi.Controllers
{
    [RoutePrefix("v1/iStore")]
    public class iStoreController : ApiController
    {
        [HttpPost]
        [Route("EvaluateTransModel")]
        public async Task<TransactionModelResponse> EvaluateTransModel([FromBody] Transaction[] transactions)
        {      
            using (var client = new HttpClient())
            {
                var request = new
                {
                    Inputs = new Dictionary<string, Transaction[]>() { { "Input", transactions } }
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "xX8rdSgFWkkZvh+6rOXcLA9oGeB/TYqRWmukL10WW6ohPHe/84rgU9iHaIpb0AWJnHaX6xd/aAlHXsXuG1IKdA==");
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    new Uri("https://ussouthcentral.services.azureml.net/workspaces/54d4c402587345a691db9634c2ce90d5/services/a1a94d3d81884c36861dd77e47200a9f/execute?api-version=2.0&format=swagger"),
                    request
                );

                var responseStr = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TransactionModelResponse>(responseStr);
                }
                else
                {
                    throw new ApplicationException(responseStr);
                }
            }
        }

        [HttpPost]
        [Route("EvaluateStoreModel")]
        public async Task<StoreModelResponse> EvaluateStoreModel([FromBody] Transaction[] transactions)
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    Inputs = new Dictionary<string, Transaction[]>() { { "Input", transactions } }
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "rJ22+//BH3RlMsufrKgeBOsTlr+cgG60uaKvKC0pkp0cdKeTfaqh2T5OiUE60yv+RL3K30MYffvvkAref8eJPw==");
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    new Uri("https://ussouthcentral.services.azureml.net/workspaces/54d4c402587345a691db9634c2ce90d5/services/f164c0cc3e554c6d90028d04b9f48f46/execute?api-version=2.0&format=swagger"),
                    request
                );

                var responseStr = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<StoreModelResponse>(responseStr);
                }
                else
                {
                    throw new ApplicationException(responseStr);
                }
            }
        }

        [HttpGet]
        [Route("GetTransModelClustering")]
        public async Task<TransactionModelResponse> GetTransModelClustering()
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>(){ }
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "aOkzdldqcL07QeS7bISOMDrOUNHinedec5mM4WhHGfpNS5d1HAbmBs7Sv9A5B04GxBgiVn5wJu8aJqyzWte8Zg==");
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    new Uri("https://ussouthcentral.services.azureml.net/workspaces/54d4c402587345a691db9634c2ce90d5/services/826fec45d3cd4407ba6d5f555077499a/execute?api-version=2.0&format=swagger"),
                    request
                );

                var responseStr = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TransactionModelResponse>(responseStr);
                }
                else
                {
                    throw new ApplicationException(responseStr);
                }
            }
        }



        [HttpGet]
        [Route("GetStoreModelClustering")]
        public async Task<StoreModelResponse> GetStoreModelClustering()
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() { }
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "W2M6N9q42RG0Dg03UDRVxINAHot/0Jav3IiN/NLouz43un9r/ropROOmy37yEZOlFCOjAnky9yOiyV9HQsL6zw==");
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    new Uri("https://ussouthcentral.services.azureml.net/workspaces/54d4c402587345a691db9634c2ce90d5/services/d7b1aeb0bea34df0b6d9512b4270849e/execute?api-version=2.0&format=swagger"),
                    request
                );

                var responseStr = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<StoreModelResponse>(responseStr);
                }
                else
                {
                    throw new ApplicationException(responseStr);
                }
            }
        }

        
    }
}