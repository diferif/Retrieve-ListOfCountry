using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_ListOfCountry
{
    public class Country
    {
        public string Name { get; set; }
        public string countryRegion { get; set; }
        public string Confirmed { get; set; }
        public string Recovered { get; set; }
        public string Deaths { get; set; }
    }
}
