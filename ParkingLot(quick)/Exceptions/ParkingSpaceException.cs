namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class ParkingSpaceException : Exception
        {
            public ParkingSpaceException() : base("Parking Space Exception, Check The Space Values") { }
            public ParkingSpaceException(string message) : base(message) { }
        }
    }
}
