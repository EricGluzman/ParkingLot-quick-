namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class Moto : Vehicle
        {
            public Moto(string plateNum, CarTypes carType, int serNum) : base(0.5, plateNum, carType, serNum)
            {
            }
        }
    }
}
