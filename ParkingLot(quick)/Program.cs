namespace ParkingLot_quick_
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class ControlCenter
        {
            public List<ParkingLot> Parkings { get; private set; }

            public ControlCenter(List<ParkingLot> parkings)
            {
                Parkings = new List<ParkingLot>();
                Parkings = parkings;
            }

        }
    }
}
