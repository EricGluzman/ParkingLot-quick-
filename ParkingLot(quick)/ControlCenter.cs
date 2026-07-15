namespace ParkingLot_quick_
{
    internal partial class Program
    {
        public class ControlCenter
        {
            public List<ParkingLot> Parkings { get; private set; }
            public Timer _timer;

            public ControlCenter(List<ParkingLot> parkings)
            {
                Parkings = new List<ParkingLot>();
                Parkings = parkings;
                _timer = new Timer(BackGroundUpdate, null, TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(1));
            }
            public void PrintParkingLotInfo(ParkingLot parkingLot)
            {
                Console.WriteLine(parkingLot.ToString());
            }
            public void AddParkingLot(ParkingLot parkingLot)
            {
                if (parkingLot == null) throw new ArgumentException();
                this.Parkings.Add(parkingLot);
            }
            public void RemoveParkingLot(ParkingLot parkingLot)
            {
                for(int i = 0; i < this.Parkings.Count; i++)
                {
                    if (this.Parkings[i].ParkingSirNum == parkingLot.ParkingSirNum)
                    {
                        this.Parkings.RemoveAt(i);
                        return;
                    }
                }
                throw new ParkingLotException();
            }
            public void BackGroundUpdate(object? state) // updates for every vehicle at every parking lot the cars data.
            {
                for(int i = 0; i < this.Parkings.Count; i++)
                {
                    for(int j = 0; j < this.Parkings[i].ParkedVehiclesCount(); j++)
                    {
                        var currentvehicle = this.Parkings[i].ReturnVehicleAt(j);
                        currentvehicle.AddMinutes(1);
                        currentvehicle.AddPriceToPay(0.5 * this.Parkings[i].CostRate);
                    }

                }
                  
            }
        }
    }
}
