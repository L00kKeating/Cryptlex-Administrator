using Cryptlex_Administrator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cryptlex_Administrator
{
    internal class APIHandler
    {
        public APIHandler(UserCredentials userCreds) {
            UserCredentials = userCreds;
        }

        public const string BaseURl = "https://api.cryptlex.com/v3/";
        public UserCredentials UserCredentials { get; set; }

        


        #region Products

        #region Authentication
        public HttpResponseMessage Login()
        {
            //get username from db

            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl);

            var json = System.Text.Json.JsonSerializer.Serialize(UserCredentials.ToJsonModel());
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("accounts/login", content);

            if (response.IsFaulted)
                return null;

            return response.Result;
        }
        #endregion 
        
        #region Create
        public string CreateProduct()
        {

        https://api.cryptlex.com/v3/accounts/login
            /*var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl + "products");

            var json = System.Text.Json.JsonSerializer.Serialize();
            var content = new StringContent(json, Encoding.UTF8, "application/json");*/

            throw new NotImplementedException();
        }
        #endregion 

        #region Update
        public string UpdateProduct()
        {
            throw new NotImplementedException();
        }
        #endregion 

        #region Select
        public Products GetProducts()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl);

            var response = client.GetAsync("products").Result;

            if (!response.IsSuccessStatusCode)
                return null;

            return new Products(response.Content);

        }
        public Product GetProductByID(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURl);

            var response = client.GetAsync($"products/{id}").Result;

            if (!response.IsSuccessStatusCode)
                return null;

            return new Product(response.Content);
        }
        #endregion 

        #endregion Products
    }


}
