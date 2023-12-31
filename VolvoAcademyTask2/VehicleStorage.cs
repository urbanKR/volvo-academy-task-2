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
            int manufactureYear, Color color, decimal price,
            string registrationNumber, ComfortClass comfortClass)
        {
            repository.UpdateVehicle(vehicleToUpdateId, brand, model,
            manufactureYear, color, price,
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
            var specificBrandVehicles = repository.GetVehicles().Where(v => v.Brand == brand).ToList();
            specificBrandVehicles.ForEach(v => v.ShowVehicle());
        }
        public void ShowExceededTenureVehicles(string modelName)
        {
            var exceededTenureVehicles = repository.GetVehicles().Where(v => v.ExceedsTenure == true && v.Model.Name == modelName).ToList();
            exceededTenureVehicles.ForEach(v => v.ShowVehicle());
        }
        public void ShowMatchingVehicles(VehicleBrand brand, Color color)
        {
            var matchingVehicles = repository.GetVehicles().Where(v => v.Brand == brand && v.Color == color).OrderByDescending(v => v.ComfortClass).ToList();
            ComfortClass prevVComfortClass = matchingVehicles.ElementAt(0).ComfortClass;
            Console.WriteLine($"**********Comfort class: {prevVComfortClass}***********\n");
            foreach (var v in matchingVehicles) 
            {
                if(prevVComfortClass != v.ComfortClass)
                {
                    Console.WriteLine($"**********Comfort class: {v.ComfortClass}***********\n");
                }
                v.ShowVehicle();
                prevVComfortClass = v.ComfortClass;
            }
        }
        public void ShowVehiclesRequiringMaintenance()
        {
            var requiringMaintenanceVehicles = repository.GetVehicles().Where(v => v.RequiresMaintenanceIn() <= 1000).ToList();
            requiringMaintenanceVehicles.ForEach(v => v.ShowVehicle());
        }
    }
}
