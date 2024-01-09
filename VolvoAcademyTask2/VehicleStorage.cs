using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;
using VolvoAcademyTask2.Interfaces;

namespace VolvoAcademyTask2
{
    internal class VehicleStorage : IVehicleStorage
    {
        private readonly IVehicleRepository repository;
        public VehicleStorage(IVehicleRepository vehicleRepository)
        {
            repository = vehicleRepository;
        }
        public void AddVehicle(Vehicle newVehicle)
        {
            repository.AddVehicle(newVehicle);
        }
        public Vehicle GetVehicle(int vehicleId)
        {
            return repository.GetVehicle(vehicleId);
        }
        public List<Vehicle> GetVehicles()
        {
            return repository.GetVehicles();
        }
        public void UpdateVehicle(int vehicleToUpdateId, VehicleBrand brand, VehicleModel model,
            int manufactureYear, string colorName, decimal price,
            string registrationNumber, ComfortClass comfortClass)
        {
            repository.UpdateVehicle(vehicleToUpdateId, brand, model,
            manufactureYear, colorName, price,
            registrationNumber, comfortClass);
        }
        public void RemoveVehicle(int vehicleId)
        {
            repository.RemoveVehicle(vehicleId);
        }
        public decimal GetTotalValue()
        {
            return repository.GetTotalValue();
        }
        public void ShowVehicles()
        {
            repository.GetVehicles().ForEach(v => v.ShowVehicle());
        }
        public void ShowVehicles(VehicleBrand brand)
        {
            var specificBrandVehicles = repository.GetVehicles().Where(v => v.VehicleBrand == brand).ToList();
            specificBrandVehicles.ForEach(v => v.ShowVehicle());
        }
        public void ShowExceededTenureVehicles(string modelName)
        {
            var exceededTenureVehicles = repository.GetVehicles().Where(v => v.ExceedsTenure == true && v.VehicleModel.Name == modelName).ToList();
            exceededTenureVehicles.ForEach(v => v.ShowVehicle());
        }
        public void ShowMatchingVehicles(VehicleBrand brand, Color color)
        {
            var matchingVehicles = repository.GetVehicles().Where(v => v.VehicleBrand == brand && v.Color == color).OrderByDescending(v => v.ComfortClass).ToList();
            if (matchingVehicles.Any())
            {
                ComfortClass prevVComfortClass = matchingVehicles.ElementAt(0).ComfortClass;
                Console.WriteLine($"**********Comfort class: {prevVComfortClass}***********\n");
                foreach (var v in matchingVehicles)
                {
                    if (prevVComfortClass != v.ComfortClass)
                    {
                        Console.WriteLine($"**********Comfort class: {v.ComfortClass}***********\n");
                    }
                    v.ShowVehicle();
                    prevVComfortClass = v.ComfortClass;
                }
            }
        }
        public void ShowVehiclesRequiringMaintenance()
        {
            var requiringMaintenanceVehicles = repository.GetVehicles().Where(v => v.RequiresMaintenanceIn() <= 1000).ToList();
            requiringMaintenanceVehicles.ForEach(v => v.ShowVehicle());
        }

        public void DisplayMethods()
        {
            Console.WriteLine("Diplaying methods:\n");
            Console.WriteLine("**********ShowVehicles()**********\n");
            ShowVehicles();
            Console.WriteLine("a) ShowVehicles(VehicleBrand.Opel)\n");
            ShowVehicles(VehicleBrand.Opel);
            Console.WriteLine("b) ShowExceededTenureVehicles(\"Astra\")\n");
            ShowExceededTenureVehicles("Astra");
            Console.WriteLine("c) GetTotalValue()\n");
            Console.WriteLine(GetTotalValue() + "\n");
            Console.WriteLine("d) ShowMatchingVehicles(VehicleBrand.Opel, Color.LightPink)\n");
            ShowMatchingVehicles(VehicleBrand.Opel, Color.LightPink);
            Console.WriteLine("e) ShowVehiclesRequiringMaintenance()\n");
            ShowVehiclesRequiringMaintenance();
        }
    }
}
