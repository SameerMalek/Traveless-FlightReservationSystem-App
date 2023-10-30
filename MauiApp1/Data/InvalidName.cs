using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class InvalidName : Exception

    {
        public InvalidName() : base("Invalid Name") { }

        public InvalidName(string message) : base(message) { }
    }
}
