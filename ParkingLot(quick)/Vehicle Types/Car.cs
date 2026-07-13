namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class Car : Vehicle
        {
            public Car(string plateNum, CarTypes carType, int serNum) : base(1, plateNum, carType, serNum)
            {
            }
        }
    }
}
