using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;
using VolvoAcademyTask2.Interfaces;

namespace VolvoAcademyTask2.Repository
{
    internal class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> vehicles;
        public VehicleRepository()
        {
            vehicles = new List<Vehicle>();
        }
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
        public void UpdateVehicle(int vehicleToUpdateId, VehicleBrand brand, VehicleModel model,
            int manufactureYear, Color color, decimal price,
            string registrationNumber, ComfortClass comfortClass)
        {
            var vehicleToUpdate = GetVehicle(vehicleToUpdateId);
            vehicleToUpdate.Brand = brand;
            vehicleToUpdate.Model = model;
            vehicleToUpdate.ManufactureYear = manufactureYear;
            vehicleToUpdate.Color = color;
            vehicleToUpdate.Price = price;
            vehicleToUpdate.RegistrationNumber = registrationNumber;
            vehicleToUpdate.ComfortClass = comfortClass;
        }
        public void RemoveVehicle(int vehicleId)
        {
            vehicles.Remove(GetVehicle(vehicleId));
        }
        public decimal GetTotalValue()
        {
            return vehicles.Sum(v => v.CalculateCurrentValue());
        }
    }
}
