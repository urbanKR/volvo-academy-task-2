using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;

namespace VolvoAcademyTask2.Interfaces
{
    internal interface IVehicleRepository
    {
        // Add new vehicle.
        void AddVehicle(Vehicle newVehicle);
        // Get Vehicle by id.
        Vehicle GetVehicle(int vehicleId);
        // Get all Vehicles.
        List<Vehicle> GetVehicles();
        // Update vehicle by id.
        abstract void UpdateVehicle(int vehicleToUpdateId, VehicleBrand Brand, VehicleModel Model,
            int ManufactureYear, string colorName, decimal Price,
            string RegistrationNumber, ComfortClass ComfortClass);
        // Remove vehicle by id.
        void RemoveVehicle(int vehicleId);
        // Calculate total value of the entire vehicle fleet owned. 
        decimal GetTotalValue();
    }
}
