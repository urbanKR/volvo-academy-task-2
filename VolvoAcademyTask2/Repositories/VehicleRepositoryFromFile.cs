using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;
using VolvoAcademyTask2.Interfaces;

namespace VolvoAcademyTask2.Repositories
{
    internal class VehicleRepositoryFromFile : IVehicleRepository
    {
        public List<Vehicle> vehicles;
        private string fileName;
        private string filePath;
        public VehicleRepositoryFromFile(string fileName)
        {
            this.fileName = fileName;
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.filePath = Path.Combine(executableLocation, "Data", fileName);
            vehicles = ReadDataFromFile();
        }
        public List<Vehicle> ReadDataFromFile()
        {
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            List<Vehicle> vehicles = [];
            if (File.Exists(this.filePath))
            {
                var fileDataJSON = new string(File.ReadAllText(this.filePath));
                var vehicleData = JsonSerializer.Deserialize<VehicleData>(fileDataJSON, serializeOptions);
                vehicles.AddRange(vehicleData.PassengerVehicles);
                vehicles.AddRange(vehicleData.CargoVehicles);
            }
            else
            {
                Console.WriteLine("Wrong File Path!");
            }
            return vehicles;
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
            int manufactureYear, string colorName, decimal price,
            string registrationNumber, ComfortClass comfortClass)
        {
            var vehicleToUpdate = GetVehicle(vehicleToUpdateId);
            vehicleToUpdate.VehicleBrand = brand;
            vehicleToUpdate.VehicleModel = model;
            vehicleToUpdate.ManufactureYear = manufactureYear;
            vehicleToUpdate.ColorName = colorName;
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
