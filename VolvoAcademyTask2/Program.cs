using VolvoAcademyTask2.Interfaces;
using VolvoAcademyTask2.Repositories;
using VolvoAcademyTask2.Repository;

namespace VolvoAcademyTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle File Repository Tests

            VehicleStorage vehicleStorage = new VehicleStorage(new VehicleRepositoryFromFile("vehicleData.json"));
            vehicleStorage.ShowVehicles();
            //vehicleStorage.ShowVehicles(Enums.VehicleBrand.Opel);
            //vehicleStorage.ShowExceededTenureVehicles("Astra");
            //Console.WriteLine(vehicleStorage.GetTotalValue());
            //vehicleStorage.ShowMatchingVehicles(Enums.VehicleBrand.Opel, System.Drawing.Color.LightPink);
            //vehicleStorage.ShowVehiclesRequiringMaintenance();

            //Vehicle Repository Tests

            //VehicleStorage vehicleStorage = new VehicleStorage(new VehicleRepository());

            //vehicleStorage.AddVehicle(new PassengerVehicle(1, Enums.VehicleBrand.Opel, new VehicleModel(1, "Astra", 1),
            //    2002, "LightPink", 237000, "DWC8720", Enums.ComfortClass.Luxury, new TimeSpan(30, 5, 0, 0), 244000, 800));
            //vehicleStorage.AddVehicle(new PassengerVehicle(2, Enums.VehicleBrand.Opel, new VehicleModel(2, "Corsa", 2),
            //    2004, "LightBlue", 107000, "DWC3420", Enums.ComfortClass.Economy, new TimeSpan(7, 0, 0, 0), 50000, 600));
            //vehicleStorage.AddVehicle(new PassengerVehicle(3, Enums.VehicleBrand.Toyota, new VehicleModel(3, "Supra", 10),
            //    2000, "Pink", 10000, "DWC4444", Enums.ComfortClass.Standard, new TimeSpan(50, 5, 0, 0), 108000, 400));
            //vehicleStorage.AddVehicle(new PassengerVehicle(4, Enums.VehicleBrand.Toyota, new VehicleModel(4, "Supra", 3),
            //    2023, "LightBlue", 107000, "DWC3422", Enums.ComfortClass.Economy, new TimeSpan(7, 0, 0, 0), 50000, 600));
            //vehicleStorage.AddVehicle(new CargoVehicle(5, Enums.VehicleBrand.Toyota, new VehicleModel(5, "RAV4", 3),
            //    2002, "LightPink", 237000, "DWC8520", Enums.ComfortClass.Luxury, new TimeSpan(32, 5, 0, 0), 238000, 800));
            //vehicleStorage.AddVehicle(new CargoVehicle(6, Enums.VehicleBrand.Opel, new VehicleModel(6, "mokka", 2),
            //    2004, "LightBlue", 107000, "DWC3620", Enums.ComfortClass.Standard, new TimeSpan(7, 0, 0, 0), 50000, 600));
            //vehicleStorage.AddVehicle(new CargoVehicle(7, Enums.VehicleBrand.Toyota, new VehicleModel(7, "RAV4", 3),
            //    2002, "LightPink", 237000, "DWF8320", Enums.ComfortClass.Luxury, new TimeSpan(32, 5, 0, 0), 74000, 800));
            //vehicleStorage.AddVehicle(new CargoVehicle(8, Enums.VehicleBrand.Opel, new VehicleModel(8, "mokka", 2),
            //    2015, "LightBlue", 107000, "DWF3421", Enums.ComfortClass.Economy, new TimeSpan(7, 0, 0, 0), 5000000, 600));

            //vehicleStorage.ShowVehicles();
            //vehicleStorage.ShowVehicles(Enums.VehicleBrand.Opel);
            //vehicleStorage.ShowExceededTenureVehicles("mokka");
            //Console.WriteLine(vehicleStorage.GetTotalValue());
            //vehicleStorage.ShowMatchingVehicles(Enums.VehicleBrand.Opel, System.Drawing.Color.LightBlue);
            //vehicleStorage.ShowVehiclesRequiringMaintenance();
        }
    }
}

