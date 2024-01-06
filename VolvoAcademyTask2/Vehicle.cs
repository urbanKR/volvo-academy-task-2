using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;

namespace VolvoAcademyTask2
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VehicleBrand VehicleBrand { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public int ManufactureYear { get; set; }
        public string ColorName { get; set; }
        public Color Color => Color.FromName(ColorName);
        public decimal Price { get; set; }
        public string RegistrationNumber { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ComfortClass ComfortClass { get; set; }
        public abstract bool ExceedsTenure { get; }
        public abstract decimal CalculateCurrentValue();
        public abstract decimal RequiresMaintenanceIn();
        public abstract void ShowVehicle();
        public Vehicle()
        {
        }

        public Vehicle(int id, VehicleBrand brand, VehicleModel model, int manufactureYear,
            string colorName, decimal price, string registrationNumber, ComfortClass comfortClass) : this()
        {
            Id = id;
            VehicleBrand = brand;
            VehicleModel = model;
            ManufactureYear = manufactureYear;
            ColorName = colorName;
            Price = price;
            RegistrationNumber = registrationNumber;
            ComfortClass = comfortClass;
        }
    }
}
