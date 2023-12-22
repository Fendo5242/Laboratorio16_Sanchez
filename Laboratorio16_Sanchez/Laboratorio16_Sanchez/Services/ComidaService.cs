using Laboratorio16_Sanchez.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio16_Sanchez.Services
{
    public class ComidaService
    {
        HttpClient client = new HttpClient();

        public async Task<List<ComidaModel>> GetListingsAsync(string url)
        {
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ComidaApiResponse>(json);
                return apiResponse.Comidas;
            }
            return new List<ComidaModel>();
        }
    }

    public class ComidaApiResponse
    {
        public List<ComidaModel> Comidas { get; set; }
    }
}
