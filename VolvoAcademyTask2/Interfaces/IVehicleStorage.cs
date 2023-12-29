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

namespace VolvoAcademyTask2.Interfaces
{
    internal interface IVehicleStorage
    {
        // Add new vehicle.
        void AddVehicle();
        // Get Vehicle by id.
        Vehicle GetVehicle(int vehicleId);
        // Get all Vehicles.
        List<Vehicle> GetVehicles();
        // Update vehicle by id.
        void UpdateVehicle(int vehicleId);
        // Remove vehicle by id.
        void RemoveVehicle(int vehicleId);
        // List inventory of vehicles of specified brand.
        void ShowVehicles(string brand);
        // List of vehicles of a chosen model that have exceeded a predetermined operational tenure.
        void ShowExceededTenureVehicles(VehicleModel model);
        // Calculate total value of the entire vehicle fleet owned. 
        void CalculateTotalValue();
        // Given a preference for vehicle brand and color – show a selection of matching vehicles sorted by comfort class.
        void ShowMatchingVehicles(string brand, string color);
        // Show a list of vehicles that are within 1000 km of requiring maintenance.
        void ShowVehiclesRequiringMaintenance();
    }
}
