using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoAcademyTask2
{
    internal class PassengerVehicle : Vehicle
    {
        public TimeSpan TripDuration {  get; set; }
        public decimal TravelDistance { get; set; }
        public decimal LeeseRating { get; set;}

        public override bool ExceedsTenure => TravelDistance > 100000 || DateTime.Now.Year - ManufactureYear > 5;

        public override int CalculateCurrentValue()
        {
            throw new NotImplementedException();
        }

        public override int RequiresMaintenanceIn()
        {
            throw new NotImplementedException();
        }
    }
}
