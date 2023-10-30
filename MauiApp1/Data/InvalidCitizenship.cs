using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class InvalidCitizenship : Exception
    {
        public InvalidCitizenship() : base("The citizenship is invalid") { }
        public InvalidCitizenship(string message) : base(message) { }

    }
}
