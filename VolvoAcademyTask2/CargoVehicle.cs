using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoAcademyTask2
{
    internal class CargoVehicle : Vehicle
    {
        public TimeSpan TripDuration { get; set; }
        public decimal TravelDistance { get; set; }
        public decimal Weight { get; set; }

        public override bool ExceedsTenure => TravelDistance > 1000000 || DateTime.Now.Year - ManufactureYear > 15;
        public override decimal CalculateCurrentValue()
        {
            return Price * (decimal)Math.Pow(0.93, DateTime.Now.Year - ManufactureYear);
        }

        public override decimal RequiresMaintenanceIn()
        {
            return 5000 - TravelDistance % 15000;
        }
    }
}
