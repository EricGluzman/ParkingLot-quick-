using static ParkingLot_quick_.Program;

namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class ParkingLot
        {
            public double FreeSpace { get; private set; }
            private readonly double MaxSpace;
            private List<ParkingTicket> ParkedCars;
            public double CostRate { get; private set; }
            public readonly int ParkingSirNum;
            private static int CountParkings = 0;

            public ParkingLot(List<ParkingTicket> parkedcars, double costRate,double maxspace)
            {
                ParkedCars = new List<ParkingTicket>();
                FreeSpace = maxspace;
                ParkedCars = parkedcars;
                CostRate = costRate;
                MaxSpace = maxspace;
                this.ParkingSirNum = CountParkings + 100;
                CountParkings++;
            }
            public ParkingLot(double costRate, double maxspace)
            {
                ParkedCars = new List<ParkingTicket>();
                FreeSpace = maxspace;
                CostRate = costRate;
                MaxSpace = maxspace;
                this.ParkingSirNum = CountParkings + 100;
                CountParkings++;
            }
            private void ChangeFreeSpace(double space)
            {
                if (this.FreeSpace < space) throw new ParkingSpaceException("You cannot take up more space than is available.");
                if (this.FreeSpace + space > this.MaxSpace) throw new ParkingSpaceException("You tring to add more space than possible, check the space value.");
                this.FreeSpace += space;
            }
            public void AddVehicleToParking(Vehicle vehicle) 
            {
                if (vehicle == null) throw new ArgumentNullException();
                if (this.FreeSpace < vehicle.ParkingSpace) throw new SpaceException();
                this.ParkedCars.Add(new ParkingTicket(vehicle, 0));
                ChangeFreeSpace(-vehicle.ParkingSpace);

            }
            public void RemoveParkedVehicle(Vehicle vehicle)
            {
                if (vehicle == null) throw new NullVehicleException();
                for(int i = 0; i < this.ParkedCars.Count; i++)
                {
                    if (this.ParkedCars[i].Car.serNum == vehicle.serNum)
                    {
                        this.ParkedCars.RemoveAt(i);
                        return;
                    }
                }
                throw new NullVehicleException("The Vehicle Is Not Found.");
            }
            public void ChangeCostRate(double rate)
            {
                this.CostRate = rate;
                if (this.CostRate <= 0) this.CostRate = 1;
            }
            private string PrintCarsInfo() 
            {
                string Carsinf = "";
                for (int i = 0; i < ParkedCars.Count; i++) {
                    ParkingTicket currentcar = ParkedCars[i];
                    Carsinf += ($"Cars Serial Number: {currentcar.Car.serNum}, Car Time In The Parking Lot: {currentcar.Minutes}, To Pay: {currentcar.PriceToPay}. \n");
                }
                return Carsinf;
            }
            public override string ToString() 
            {
                return $"Free Parking Lot Spaces: {this.FreeSpace}.\n" + PrintCarsInfo();
            }
            public ParkingTicket ReturnVehicleAt(int i)
            {
                if (i < 0) throw new ArgumentException("Cant Give Negative Index");
                return this.ParkedCars[i];
            }
            public int ParkedVehiclesCount()
            {
                return this.ParkedCars.Count;
            }
        }
    }
}
