using System.Data;

namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class ParkingTicket
        {
            public Vehicle Car { get; private set; }
            public double PriceToPay { get; set; }
            public int Minutes { get; set; }

            public ParkingTicket(Vehicle car, double priceToPay)
            {
                Car = car;
                PriceToPay = priceToPay;
                Minutes = 0;
            }
            public void AddMinutes(int min)
            {
                if (min <= 0) throw new ArgumentException("Cant Add 0 Or Negative Minutes");
                this.Minutes += min;
            }
            public void AddPriceToPay(double price)
            {
                if (price <= 0) throw new ArgumentException("Cant Add 0 Or Negative Price To Pay");
                this.PriceToPay += price;
            }
        }
    }
}
