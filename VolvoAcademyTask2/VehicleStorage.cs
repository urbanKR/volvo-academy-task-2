using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VolvoAcademyTask2.Interfaces;

namespace VolvoAcademyTask2
{
    internal class VehicleStorage : IVehicleStorage
    {
        public List<Vehicle> vehicles = new List<Vehicle>();
        public void AddVehicle()
        {
            throw new NotImplementedException();
        }

        public void CalculateTotalValue()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public void ShowExceededTenureVehicles(VehicleModel model)
        {
            throw new NotImplementedException();
        }

        public void ShowMatchingVehicles(string brand, string color)
        {
            throw new NotImplementedException();
        }

        public void ShowVehicles(string brand)
        {
            throw new NotImplementedException();
        }

        public void ShowVehiclesRequiringMaintenance()
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }
    }
}
