using System.Net.Http.Headers;

namespace WEXOFlix_MVC
{
    public static class ApiHelper
    {
        //we make it static because we only want one per application
        //opens up a tcp ip port
        //thread save, and support multiable concurrent calls
        //public static HttpClient ApiClient { get; set; } 
        public static HttpClient InitializeClient(string url)
        {
            var ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return ApiClient;
        }
    }
}
