using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class FlightManager
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Files\\flights.csv");
        public static List<Flights> flightslist = new List<Flights>();
        public FlightManager()
        {
            populateflights();
        }
        public void populateflights()
        {
            Flights flight;
            foreach (string line in File.ReadLines(path))
            {
                string[] part = line.Split(',');
                string flightcode = part[0];
                string airlineName = part[1];
                string startAiport = part[2];
                string destinationAirport = part[3];
                string day = part[4];
                string time = part[5];
                int seats = Convert.ToInt32(part[6]);
                double cost = Convert.ToDouble(part[7]);

                flight = new Flights(flightcode, airlineName, startAiport, destinationAirport, day, time, seats, cost);
                flightslist.Add(flight); // add into users list
            }
        }
        public static List<Flights> GetFlights() // Return type is List<User>
        {
            return flightslist;
        }
    }
}
