using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace Retrieve_ListOfCountry
{
    public class WebAPI
    {
        public async Task<List<Country>> GetAllCountries()
        {
            List<Country> country = new List<Country>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://covid19.mathdro.id/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/confirmed?byCountry=true");

                if (response.IsSuccessStatusCode)
                {
                    List<Country> countryObj = await response.Content.ReadAsAsync<List<Country>>();

                    foreach (var c in countryObj)
                    {
                        Country ctx = new Country();
                        ctx.countryRegion = c.countryRegion;
                        ctx.Confirmed = c.Confirmed;
                        ctx.Recovered = c.Recovered;
                        ctx.Deaths = c.Deaths;
                        country.Add(ctx);
                    }
                }
            }

            return country;
        }
    }
}
