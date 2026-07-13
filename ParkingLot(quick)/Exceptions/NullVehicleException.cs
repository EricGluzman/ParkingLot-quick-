using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class NullVehicleException : Exception
        {
            public NullVehicleException() : base("The vihicle you provided, is either null or was not found.") { }
            public NullVehicleException(string message) : base(message) { }
        }
    }
}
