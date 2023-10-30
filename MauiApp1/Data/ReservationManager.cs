using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class ReservationManager
    {
        static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Files\\ReservationList.txt");
        //public static List<Reservation> Data = new List<Reservation>();

        public static List<Reservation> ReadFromFile()
        {
            var reservations = new List<Reservation>();

            string[] stream = File.ReadAllLines(path);
            
            foreach(string line in stream)
            {
                string[] data = line.Split(",");

                foreach(string info in data)
                {
                    Reservation reservation = new Reservation();

                    reservation.ReservationCode = Convert.ToString(info[0]);
                    reservation.Flightcode = Convert.ToString(info[1]);
                    reservation.Airlinename = Convert.ToString(info[2]);
                    reservation.CostOfFlight = Convert.ToString(info[3]);
                    reservation.Name = Convert.ToString(info[4]);
                    reservation.Citizenship = Convert.ToString(info[5]);
                    reservation.Status = Convert.ToString(info[6]);

                    reservations.Add(reservation);
                }
            }
            return reservations;
        }
        public void UpdateInBinaryFile(string reservationCode, string newName, string newcitizen, string newstatus)
        {
            List<Reservation> reservations = ReadFromFile();

            foreach (var reservation in reservations)
            {
                if (reservation.ReservationCode == reservationCode)
                {
                    reservation.Name = newName;
                    reservation.Citizenship= newcitizen;
                    reservation.Status = newstatus;
                    break;
                }
            }
            Reservation reservation1 = new Reservation();

            Reservation.writetofile(reservations);
        }


    }
}
