namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class Truck : Vehicle
        {
            public bool WithTrailer { get; private set; }
            public Truck(double parkingSpace, string plateNum, CarTypes carType, int serNum) : base(parkingSpace, plateNum, carType, serNum)
            {
                this.WithTrailer = false;
            }
            public void ChangeTrailerStatus(bool trailer)
            {
                this.WithTrailer = trailer;
            }

        }
    }
}
