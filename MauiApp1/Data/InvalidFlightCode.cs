using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class InvalidFlightCode : Exception
    {
        public InvalidFlightCode() : base("Flight Code is invalid") { }
        public InvalidFlightCode(string message) : base(message) { }

    }
}
