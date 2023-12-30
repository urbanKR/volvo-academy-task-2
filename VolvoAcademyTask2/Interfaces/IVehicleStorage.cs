using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using VolvoAcademyTask2.Enums;
using System.Drawing;

namespace VolvoAcademyTask2.Interfaces
{
    internal interface IVehicleStorage
    {
        // Add new vehicle.
        void AddVehicle(Vehicle newVehicle);
        // Get Vehicle by id.
        Vehicle GetVehicle(int vehicleId);
        // Get all Vehicles.
        List<Vehicle> GetVehicles();
        // Update vehicle by id.
        abstract void UpdateVehicle(int vehicleToUpdateId, VehicleBrand Brand, VehicleModel Model, 
            int ManufactureYear, Color Color, decimal Price,
            string RegistrationNumber, ComfortClass ComfortClass);
        // Remove vehicle by id.
        void RemoveVehicle(int vehicleId);
        // List all vehicles
        void ShowVehicles();
        // List inventory of vehicles of specified brand.
        void ShowVehicles(VehicleBrand brand);
        // List of vehicles of a chosen model that have exceeded a predetermined operational tenure.
        void ShowExceededTenureVehicles(string modelName);
        // Calculate total value of the entire vehicle fleet owned. 
        decimal CalculateTotalValue();
        // Given a preference for vehicle brand and color – show a selection of matching vehicles sorted by comfort class.
        void ShowMatchingVehicles(VehicleBrand brand, Color color);
        // Show a list of vehicles that are within 1000 km of requiring maintenance.
        void ShowVehiclesRequiringMaintenance();
    }
}
