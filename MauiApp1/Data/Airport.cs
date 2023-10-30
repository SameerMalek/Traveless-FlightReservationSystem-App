using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class Airport
    {
        public string airportcode;
        public string airportname;

        public string AirportCode { get; set; }
        public string Airportname { get; set; }
        public Airport(string code, string airportname)
        {
            this.AirportCode = code;
            this.Airportname = airportname;
        }
    }
}
