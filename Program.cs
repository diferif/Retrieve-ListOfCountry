using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_ListOfCountry
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            WebAPI data = new WebAPI();
            countries = await data.GetAllCountries();

            foreach (var c in countries)
            {
                Console.WriteLine($"Name: {c.countryRegion} | Confirmed: {c.Confirmed} | Recovered: {c.Recovered} | Deaths: {c.Deaths}");
            }

            Console.Read();
        }
    }
}
