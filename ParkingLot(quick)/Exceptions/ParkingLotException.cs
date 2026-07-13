namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class ParkingLotException : Exception
        {
            public ParkingLotException() : base("The Parking Lot you provided, is either null or was not found.") { }
            public ParkingLotException(string message) : base(message) { }
        }
    }
}
