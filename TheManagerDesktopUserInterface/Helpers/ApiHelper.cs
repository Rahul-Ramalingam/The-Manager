using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TheManagerDesktopUserInterface.Helpers
{
    public class ApiHelper
    {
        public HttpClient ApiClient { get; set; }

        public ApiHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("")
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task Authenticate(string userName, string passWord)
        {
            var data = new FormUrlEncodedContent(new[] { 
                new KeyValuePair<string,string>("grant_type", "password"),
                new KeyValuePair<string,string>("username", userName),
                new KeyValuePair<string,string>("password", passWord),
            });

            using(HttpResponseMessage response = await ApiClient.PostAsync("/Token", data))
            {

            }
        }
    }
}
