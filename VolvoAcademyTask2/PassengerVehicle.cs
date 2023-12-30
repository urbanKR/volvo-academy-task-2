using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VolvoAcademyTask2.Enums;

namespace VolvoAcademyTask2
{
    internal class PassengerVehicle : Vehicle
    {
        public TimeSpan TripDuration {  get; set; }
        public decimal TravelDistance { get; set; }
        public decimal LeeseRating { get; set;}

        public override bool ExceedsTenure => TravelDistance > 100000 || DateTime.Now.Year - ManufactureYear > 5;
        public PassengerVehicle(int id, VehicleBrand brand, VehicleModel model, int manufactureYear, 
            Color color, decimal price, string registrationNumber, ComfortClass comfortClass,
            TimeSpan tripDuration, decimal travelDistance, decimal leeseRating) 
            : base(id, brand, model, manufactureYear, color, price, registrationNumber, comfortClass)
        {
            TripDuration = tripDuration;
            TravelDistance = travelDistance;
            LeeseRating = leeseRating;
        }

        public override decimal CalculateCurrentValue()
        {
            return  Price * (decimal) Math.Pow(0.9, DateTime.Now.Year - ManufactureYear);
        }

        public override decimal RequiresMaintenanceIn()
        {
            return 5000 - TravelDistance % 5000; 
        }

        public override void ShowVehicle()
        {
            Console.WriteLine($"type: {this.GetType().Name}, id: {this.Id}, brand: {this.Brand}, model: {this.Model.Name}, manufactureYear: {this.ManufactureYear}, " +
                  $"color: {this.Color}, price: {this.Price:C},\nregistrationNumber: {this.RegistrationNumber}, " +
                  $"comfortClass: {this.ComfortClass}, tripDuration: {this.TripDuration}, " +
                  $"travelDistance: {this.TravelDistance} km, leeseRating: {this.LeeseRating}\n");
        }
    }
}
