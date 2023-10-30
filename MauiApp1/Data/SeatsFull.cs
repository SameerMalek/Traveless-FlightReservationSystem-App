using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class SeatsFull : Exception
    {
        public SeatsFull() : base("No more seats are available") { }
        public SeatsFull(string message) : base(message) { }
    }
}
