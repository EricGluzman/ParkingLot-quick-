namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class SpaceException : Exception
        {
            public SpaceException() : base("There Is No Space In The Parking.") { }
            public SpaceException(string message) : base(message) { }
        }
    }
}
