using  System.Threading.Tasks;
using BlazorAPIClient.Dtos;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorAPIClient.DataServices
{
    public class RESTSpaceXDataService : ISpaceXDataService
    {
        private HttpClient _httpclient;
        public RESTSpaceXDataService(HttpClient httpclient)
        {
            _httpclient = httpclient;   
        }
        public async Task<LaunchDto[]> GetAllLaunches()
        {
            var launches = await _httpclient.GetFromJsonAsync<LaunchDto[]>("/rest/launches/");
            return launches;
            
        }

    }
}