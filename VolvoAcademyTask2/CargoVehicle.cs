using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;

namespace VolvoAcademyTask2
{
    internal class CargoVehicle : Vehicle
    {
        public TimeSpan TripDuration { get; set; }
        public decimal TravelDistance { get; set; }
        public decimal Weight { get; set; }

        public override bool ExceedsTenure => TravelDistance > 1000000 || DateTime.Now.Year - ManufactureYear > 15;
        public CargoVehicle(int id, VehicleBrand brand, VehicleModel model, int manufactureYear,
            Color color, decimal price, string registrationNumber, ComfortClass comfortClass,
            TimeSpan tripDuration, decimal travelDistance, decimal weight)
            : base(id, brand, model, manufactureYear, color, price, registrationNumber, comfortClass)
        {
            TripDuration = tripDuration;
            TravelDistance = travelDistance;
            Weight = weight;
        }
        public override decimal CalculateCurrentValue()
        {
            return Price * (decimal)Math.Pow(0.93, DateTime.Now.Year - ManufactureYear);
        }

        public override decimal RequiresMaintenanceIn()
        {
            return 15000 - TravelDistance % 15000;
        }

        public override void ShowVehicle()
        {
            Console.WriteLine($"type: {this.GetType().Name}, id: {this.Id}, brand: {this.Brand}, model: {this.Model.Name}, manufactureYear: {this.ManufactureYear}, " +
                  $"color: {this.Color}, price: {this.Price:C},\nregistrationNumber: {this.RegistrationNumber}, " +
                  $"comfortClass: {this.ComfortClass}, tripDuration: {this.TripDuration}, " +
                  $"travelDistance: {this.TravelDistance} km, Weight: {this.Weight}\n");

        }
    }
}
