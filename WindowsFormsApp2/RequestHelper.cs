using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Configuration;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.IO;
using System.Web;
using System.Web.UI;

namespace WindowsFormsApp2
{
    public static class RequestHelper
    {
       private static string authHeader = ConfigurationManager.AppSettings["apiKey"];
        public static readonly string baseURL = "https://gorest.co.in/";
        public static async Task<string> GetALL()
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Bearer", authHeader);
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "public-api/users"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Get(string id)
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Bearer", authHeader);

                using (HttpResponseMessage response = await client.GetAsync(baseURL + "/public-api/users/"+ id))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                     
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Post(string name, string email,string gender,string status)
        {
            var stringContent = new FormUrlEncodedContent(new[]
 {
   
    new KeyValuePair<string, string>("name", name),
    new KeyValuePair<string, string>("email", email),
    new KeyValuePair<string, string>("gender", gender),
    new KeyValuePair<string, string>("status", status),
});
          
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", authHeader);
               
                using (HttpResponseMessage response = await client.PostAsync(baseURL + "/public-api/users/", stringContent)) 
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                       
                        }
                       

                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Put(string id,string name, string email,string gender,string status)
        {
            var stringContent = new FormUrlEncodedContent(new[]
            {
    new KeyValuePair<string, string>("id", id),
    new KeyValuePair<string, string>("name", name),
    new KeyValuePair<string, string>("email", email),
    new KeyValuePair<string, string>("gender", gender),
    new KeyValuePair<string, string>("status", status),
});
            
          

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", authHeader);


                using (HttpResponseMessage response = await client.PutAsync(baseURL + "/public-api/users/" + id, stringContent))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Delete(string id)
        {

            var clientHandler = new HttpClientHandler();


            using (var client = new HttpClient(clientHandler))
            {
                client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", authHeader);


                using (HttpResponseMessage response = await client.DeleteAsync(baseURL + "/public-api/users/" + id))
                {
                    using (HttpContent content = response.Content)
                    {
                        MessageBox.Show(response.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {

                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static string BeautifyJson(string jsonStr)
        {
           
                JToken parseJson = JToken.Parse(jsonStr);

                return parseJson.ToString(Formatting.Indented);
            
            
        }
    }
}

