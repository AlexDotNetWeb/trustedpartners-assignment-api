using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
//using System.Text.Json;
using System.Threading.Tasks;
using static trustedpartners_assignment.Models.DuckModel;

namespace trustedpartners_assignment.Controllers
{
    [EnableCors("ClientPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        IHttpClientFactory _httpClient;
        public ProxyController(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory;
        }
        [HttpGet("SearchDuckProxy")]
        public async Task<List<Topics>> SearchDuckProxy(string query)
        {
            string uri = $"http://api.duckduckgo.com/?q={query}&format=json";
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), uri))
                {
                    var response = await httpClient.SendAsync(request);
                    using (HttpContent content = response.Content)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        return  Newtonsoft.Json.JsonConvert.DeserializeObject<MainRoot>(jsonString).RelatedTopics.Where(x=>!string.IsNullOrEmpty(x.FirstURL)&& !string.IsNullOrEmpty(x.Text)).ToList();

                    }
                }
            }
        }

    }
}
