using MyAuthen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyAuthen.Services
{
    public class NetworkService
    {
        // http://codemobiles.com/adhoc/youtubes/index_new.php?username=admin&password=password&type=foods
        public static async Task<YoutubeResponse> GetData(User userBean, String type = "superhero")
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // step1 
                    const string baseUrl = "http://codemobiles.com";
                    // step 2 path
                    string function = "/adhoc/youtubes/index_new.php" +
                        $"?username={userBean.UserName}&password={userBean.Password}&type={type}";

                    client.BaseAddress = new Uri(baseUrl);

                    //step 3
                    var response = await client.GetAsync(function);  // Get http method
                    response.EnsureSuccessStatusCode();

                    var stringResponse = await response.Content.ReadAsStringAsync();
                    //step 4
                    YoutubeResponse result = JsonConvert.DeserializeObject<YoutubeResponse>(stringResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
            return null;
        }
    }
}
