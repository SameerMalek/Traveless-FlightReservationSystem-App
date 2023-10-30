using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class Flights
    {
        private string flightCode;
        private string airlineName;
        private string startAirport;
        private string destinationAirport;
        private int seats;
        private string day;
        private string time;
        private double cost;

        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string Airline { get => airlineName; set => airlineName = value; }
        public string Start { get => startAirport; set => startAirport = value; }
        public string Destination { get => destinationAirport; set => destinationAirport = value; }
        public int Seats { get => seats; set => seats = value; }
        public string Day { get => day; set => day = value; }
        public string Time { get => time; set => time = value; }
        public double Cost { get => cost; set => cost = value; }
        public Flights()
        {
        }
        public Flights(string flightcode, string airline, string start, string destination, string day, string time, int seats, double cost)
        {
            this.flightCode = flightcode;
            this.airlineName = airline;
            this.startAirport = start;
            this.destinationAirport = destination;
            this.day = day;
            this.time = time;
            this.seats = seats;
            this.cost = cost;
        }
    }
}
