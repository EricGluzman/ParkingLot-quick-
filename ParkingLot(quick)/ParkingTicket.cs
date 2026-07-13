namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class ParkingTicket
        {
            public Vehicle Car { get; private set; }
            public double PriceToPay { get; set; }
            public double Minutes { get; set; }

            public ParkingTicket(Vehicle car, double priceToPay, double minutes)
            {
                Car = car;
                PriceToPay = priceToPay;
                Minutes = minutes;
            }
        }
    }
}
