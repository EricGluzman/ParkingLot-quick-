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
                if (this.FreeSpace < space) throw new ParkingSpaceException("You cannot take up more space than is available.");
                if (this.FreeSpace + space > 10) throw new ParkingSpaceException("You tring to add more space than possible, check the space value.");
                this.FreeSpace += space;
            }
            public void AddVehicleToPaking(Vehicle vehicle)
            {
                if (vehicle == null) throw new ArgumentNullException();
                this.ParkedCars.Add(new ParkingTicket(vehicle, 0, 0));
            }
            public void RemoveParkedVehicle(Vehicle vehicle)
            {
                if (vehicle == null) throw new NullVehicleException();
                for(int i = 0; i < this.ParkedCars.Count; i++)
                {
                    if (this.ParkedCars[i].Car.serNum == vehicle.serNum) this.ParkedCars.RemoveAt(i);
                    return;
                }
                throw new NullVehicleException("The Vehicle Is Not Found.");
            }
            public void ChangeCostRate(double rate)
            {
                this.CostRate = rate;
                if (this.CostRate <= 0) this.CostRate = 1;
            }
            private string PrintCarsInfo() // print carr name and its sernum + the amount of time it staid 
            {

            }
            public override string ToString() // print free space + use Printcarsinfo to print the cars info
            {
                return 
            }
        }
    }
}
