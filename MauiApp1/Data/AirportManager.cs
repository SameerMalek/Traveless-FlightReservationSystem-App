using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class AirportManager
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Files\\airports.csv");
        public static List<Airport> Data = new List<Airport>();

        public AirportManager()
        {
            ReadAirportdata();
        }

        public void ReadAirportdata()
        {
            Airport air;
            foreach (string lines in File.ReadAllLines(path))
            {
                string[] sep = lines.Split(',');
                string airportcode = sep[0];
                string airportname = sep[1];
                air = new Airport(airportcode, airportname);
                Data.Add(air);
            }
        }
        public static List<Airport> GetAirports()
        {
            return Data;
        }
    }
}
