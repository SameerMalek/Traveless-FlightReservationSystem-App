using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class Reservation
    {
        public Reservation() { }

        private string reservationCode;
        private string flightcode;
        private string airlinename;
        private string costOfFlight;
        private string name;
        private string citizenship;
        private string status;

        public string ReservationCode { get => reservationCode; set => reservationCode = value; }
        public string Flightcode { get => flightcode; set => flightcode = value; }
        public string Airlinename { get => airlinename; set => airlinename = value; }
        public string CostOfFlight { get => costOfFlight; set => costOfFlight = value; }
        public string Name { get => name; set => name = value; }
        public string Citizenship { get => citizenship; set => citizenship = value; }
        public string Status { get => status; set => status = value; }

        public Reservation(string reservationCode, string flightcode, string airlinename, string costOfFlight, string name, string citizenship, string status)
        {
            this.reservationCode = reservationCode;
            this.flightcode = flightcode;
            this.airlinename = airlinename;
            this.costOfFlight = costOfFlight;
            this.name = name;
            this.citizenship = citizenship;
            this.status = status;
        }

        public static void writetofile(List<Reservation> res)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Files\\ReservationList.txt");
            using (StreamWriter stream = new StreamWriter(path))
                {
                    foreach (var reservation in res)
                    {
                        stream.Write(reservation.reservationCode, ',');
                        stream.Write(reservation.flightcode, ',');
                        stream.Write(reservation.airlinename, ',');
                        stream.Write(reservation.costOfFlight, ',');
                        stream.Write(reservation.name, ',');
                        stream.Write(reservation.citizenship, ',');
                        stream.Write(reservation.status);
                    }
                }
            
        }
    }
}
