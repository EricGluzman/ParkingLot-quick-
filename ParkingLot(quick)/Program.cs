using System.Reflection.Metadata.Ecma335;

namespace ParkingLot_quick_
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var veh1 = new Car("ABCD456", 789);
            var veh2 = new Car("aads89asd", 7456);
            var veh3 = new Car("SDGFDS78", 782);
            var veh4 = new Car("DAS564asd", 2549);
            var veh5 = new Car("asd87123", 674);
            var park1 = new ParkingLot(1.5, 15);
            var park2 = new ParkingLot(2, 10);
            var park3 = new ParkingLot(1, 25);
            park1.AddVehicleToParking(veh1);
            park1.AddVehicleToParking(veh2);
            park2.AddVehicleToParking(veh3);
            park2.AddVehicleToParking(veh4);
            park3.AddVehicleToParking(veh5);


            List<ParkingLot> parkings = new List<ParkingLot>() { park1, park2, park3, };
            var control1 = new ControlCenter(parkings);
            control1.PrintParkingLotInfo(park1);
            control1.PrintParkingLotInfo(park2);
            control1.PrintParkingLotInfo(park3);
            Thread.Sleep(TimeSpan.FromMinutes(1));
            control1.PrintParkingLotInfo(park1);
            control1.PrintParkingLotInfo(park2);
            control1.PrintParkingLotInfo(park3);
        }
    }
}
