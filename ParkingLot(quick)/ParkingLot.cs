namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class ParkingLot
        {
            public double FreeSpace { get; private set; }
            private readonly double MaxSpace;
            private List<ParkingTicket> ParkedCars;
            private double CostRate;

            public ParkingLot(double freeSpace, List<ParkingTicket> parkedcars, double costRate,double maxspace)
            {
                ParkedCars = new List<ParkingTicket>();
                FreeSpace = freeSpace;
                ParkedCars = parkedcars;
                CostRate = costRate;
                MaxSpace = maxspace;
            }
            public void ChangeFreeSpace(double space)
            {
                if (FreeSpace < space) throw new ParkingSpaceException("You cannot take up more space than is available.");
                if (FreeSpace + space > 10) throw new ParkingSpaceException("You tring to add more space than possible, check the space value.");
                this.FreeSpace += space;
            }
            public void AddVehicleToPaking(Vehicle vehicle)
            {
                if (vehicle == null) throw new ArgumentNullException();
                ParkedCars.Add(new ParkingTicket(vehicle, 0, 0));
            }
            public void RemoveParkedVehicle(Vehicle vehicle)
            {
                if (vehicle == null) throw new NullVehicleException();
                for(int i = 0; i < ParkedCars.Count; i++)
                {
                    if (ParkedCars[i].Car.serNum == vehicle.serNum) ParkedCars.RemoveAt(i);
                    return;
                }
                throw new NullVehicleException("The Vehicle Is Not Found.");
            }

        }
    }
}
