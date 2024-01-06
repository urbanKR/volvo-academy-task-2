namespace VolvoAcademyTask2.Repositories
{
    public class VehicleData
    {

        public VehicleData() { }
        public IEnumerable<PassengerVehicle> PassengerVehicles { get; set; }
        public IEnumerable<CargoVehicle> CargoVehicles { get; set; }
    }
}
