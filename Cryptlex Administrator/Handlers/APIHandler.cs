using Cryptlex_Administrator.Classes;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Cryptlex_Administrator
{
    internal class APIHandler
    {
        public APIHandler() { }


        public const string BaseURl = "https://api.eu.cryptlex.com/v3/";
        public UserCredentials UserCredentials { get; set; }
        public const string Token = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJhY2NvdW50OnJlYWQiLCJhY2NvdW50OndyaXRlIiwiYWN0aXZhdGlvbjpyZWFkIiwiYW5hbHl0aWNzOnJlYWQiLCJhdXRvbWF0ZWRFbWFpbDpyZWFkIiwiYXV0b21hdGVkRW1haWw6d3JpdGUiLCJhdXRvbWF0ZWRFbWFpbEV2ZW50TG9nOnJlYWQiLCJldmVudExvZzpyZWFkIiwiZmVhdHVyZUZsYWc6cmVhZCIsImZlYXR1cmVGbGFnOndyaXRlIiwiaW52b2ljZTpyZWFkIiwibGljZW5zZTpyZWFkIiwibGljZW5zZTp3cml0ZSIsImxpY2Vuc2VQb2xpY3k6cmVhZCIsImxpY2Vuc2VQb2xpY3k6d3JpdGUiLCJtYWludGVuYW5jZVBvbGljeTpyZWFkIiwibWFpbnRlbmFuY2VQb2xpY3k6d3JpdGUiLCJvcmdhbml6YXRpb246cmVhZCIsIm9yZ2FuaXphdGlvbjp3cml0ZSIsInBheW1lbnRNZXRob2Q6cmVhZCIsInBheW1lbnRNZXRob2Q6d3JpdGUiLCJwZXJzb25hbEFjY2Vzc1Rva2VuOndyaXRlIiwicHJvZHVjdDpyZWFkIiwicHJvZHVjdDp3cml0ZSIsInByb2R1Y3RWZXJzaW9uOnJlYWQiLCJwcm9kdWN0VmVyc2lvbjp3cml0ZSIsInJlbGVhc2U6cmVhZCIsInJlbGVhc2U6d3JpdGUiLCJyZXNlbGxlcjpyZWFkIiwicmVzZWxsZXI6d3JpdGUiLCJyb2xlOnJlYWQiLCJyb2xlOndyaXRlIiwic2VnbWVudDpyZWFkIiwic2VnbWVudDp3cml0ZSIsInNlbmRpbmdEb21haW46cmVhZCIsInNlbmRpbmdEb21haW46d3JpdGUiLCJ0YWc6cmVhZCIsInRhZzp3cml0ZSIsInRyaWFsQWN0aXZhdGlvbjpyZWFkIiwidHJpYWxBY3RpdmF0aW9uOndyaXRlIiwidHJpYWxQb2xpY3k6cmVhZCIsInRyaWFsUG9saWN5OndyaXRlIiwidXNlcjpyZWFkIiwidXNlcjp3cml0ZSIsIndlYmhvb2s6cmVhZCIsIndlYmhvb2s6d3JpdGUiLCJ3ZWJob29rRXZlbnRMb2c6cmVhZCJdLCJzdWIiOiIxMzE0Mzc3My1jNzVlLTQ1NGUtOTk2ZS0xY2EzZGYzOGExMjUiLCJlbWFpbCI6Imx1a2VrZWF0aW5nMjAwMEBnbWFpbC5jb20iLCJqdGkiOiJhM2I0MmUzNy1mYWU3LTQzNmEtYjM1MS1mMzM3NThjNmZjMWUiLCJpYXQiOjE3MTUwMjEyODMsInRva2VuX3VzYWdlIjoicGVyc29uYWxfYWNjZXNzX3Rva2VuIiwidGVuYW50aWQiOiI5ZmNhOTQ3OC04OGM2LTRhNDgtYmFmYy01ODNiNjU4M2JiMTYiLCJleHAiOjE3MTUyOTIwMDAsImF1ZCI6Imh0dHBzOi8vYXBpLmV1LmNyeXB0bGV4LmNvbSJ9.XNJGoRZGW4rKId8AnokB464QwqVJgmh-30o4pr7o0UT5tgwjlI9-G1XqE4zVcQxqrjKMCISbbPggGBNOF2N7Mf0iPGJPs2l1s6QNs49wakm1kgAq6Ud0_TVL29VjUfxZNS8XReXquL5Py8gRLk0BP7I6xnEg0sOWGWpmvsJNBhj5iDT-l74F5vhFKFN55nlomYu2XZyyPFGQ1-xxlDyHhS8BKjc6YBZ6QunHr7o5Y3wghRM1ES4HO74oHOknR43x_R6JxVTuNr-bg1eJ4YoJKwVKY23PVxRJUZWnzkoCGIYo4-wIJUGbqgkk9ynuw6AR9QQirBba7tw2EdsodOsi-Q";


        #region Create
        internal static void CreateProduct(string name, string displayName, string templateID, string description)
        {
            var product = new NewProductModel(name, displayName, templateID, description);

            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);


            var json = System.Text.Json.JsonSerializer.Serialize(product);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = client.PostAsync("products", httpContent).Result;

            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());
        }


        internal static string CreateLiscence(string productId)
        {
            var liscence = new ProductLicense(productId);

            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);


            var json = System.Text.Json.JsonSerializer.Serialize(liscence);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = client.PostAsync("licenses", httpContent).Result;

            if (!response.IsSuccessStatusCode)
                throw new Exception("Could not create license.");

            var result = response.Content.ReadAsStringAsync().Result;

            var productLiscence = JsonSerializer.Deserialize<newProductLiscenceModel>(result);
            liscence.Key = productLiscence.key;

            return liscence.Key;

        }
        #endregion

        #region Update
        public string UpdateProduct()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Select
        public LiscenceTemplates GetLiscenceTemplates()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

            var response = client.GetAsync("license-templates").Result;

            if (!response.IsSuccessStatusCode)
                return null;

            var result = response.Content.ReadAsStringAsync().Result;
            return new LiscenceTemplates(result);
        }
        public Products GetProducts()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

            var response = client.GetAsync("products").Result;

            if (!response.IsSuccessStatusCode)
                return null;

            var result = response.Content.ReadAsStringAsync().Result;
            return new Products(result);
        }
        #endregion
    }
}


