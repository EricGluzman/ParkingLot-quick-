namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public abstract class Vehicle
        {
            public readonly double ParkingSpace;
            public string PlateNum { get; private set; }
            public CarTypes CarType { get; private set; }
            public readonly int serNum;

            protected Vehicle(double parkingSpace, string plateNum,int serNum)
            {
                ParkingSpace = parkingSpace;
                PlateNum = plateNum;
                CarType = CarTypes.Null;
                this.serNum = serNum;
            }
        }
    }
}
