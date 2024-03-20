using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using seeri.Models;
namespace seeri
{
    public class DataService
    {
        public async Task<List<News>> GetNewsFromApi(string apiUrl)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(apiUrl);
            var newsList = JsonConvert.DeserializeObject<List<News>>(response);
            return newsList;
        }
    }
}