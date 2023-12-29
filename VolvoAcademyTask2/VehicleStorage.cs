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
        public List<Vehicle> vehicles = new List<Vehicle>();
        public void AddVehicle(Vehicle newVehicle)
        {
            vehicles.Add(newVehicle);
        }
        public Vehicle GetVehicle(int vehicleId)
        {
            return vehicles.FirstOrDefault(v => v.Id == vehicleId);
        }
        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }
        public void UpdateVehicle(int vehicleToUpdateId, VehicleBrand Brand, VehicleModel Model,
            int ManufactureYear, Color Color, decimal Price,
            string RegistrationNumber, ComfortClass ComfortClass)
        {
            var vehicleToUpdate = GetVehicle(vehicleToUpdateId);
            vehicleToUpdate.Brand = Brand;
            vehicleToUpdate.Model = Model;
            vehicleToUpdate.ManufactureYear = ManufactureYear;
            vehicleToUpdate.Color = Color;
            vehicleToUpdate.Price = Price;
            vehicleToUpdate.RegistrationNumber = RegistrationNumber;
            vehicleToUpdate.ComfortClass = ComfortClass;
        }
        public void RemoveVehicle(int vehicleId)
        {
            vehicles.Remove(GetVehicle(vehicleId));
        }
        public void ShowVehicles(VehicleBrand brand)
        {
            var specificBrandVehicles = vehicles.Where(v => v.Brand == brand).ToList();
            specificBrandVehicles.ForEach(Console.WriteLine);
        }
        public void ShowExceededTenureVehicles(VehicleModel model)
        {
            var exceededTenureVehicles = vehicles.Where(v => v.ExceedsTenure == true && v.Model == model).ToList();
            exceededTenureVehicles.ForEach(Console.WriteLine);
        }
        public decimal CalculateTotalValue()
        {
            return vehicles.Sum(v => v.CalculateCurrentValue());
        }
        public void ShowMatchingVehicles(VehicleBrand brand, Color color)
        {
            var matchingVehicles = vehicles.Where(v => v.Brand == brand && v.Color == color).GroupBy(v => v.ComfortClass).ToList();
            matchingVehicles.ForEach(Console.WriteLine);
        }
        public void ShowVehiclesRequiringMaintenance()
        {
            var requiringMaintenanceVehicles = vehicles.Where(v => v.RequiresMaintenanceIn() <= 1000).ToList();
            requiringMaintenanceVehicles.ForEach(Console.WriteLine);
        }
    }
}
