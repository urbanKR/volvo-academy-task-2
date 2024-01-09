using VolvoAcademyTask2.Interfaces;
using VolvoAcademyTask2.Repositories;
using VolvoAcademyTask2.Repository;

namespace VolvoAcademyTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle File Repository Tests
            VehicleStorage vehicleStorage = new VehicleStorage(new VehicleRepositoryFromFile("vehicleData.json"));
            vehicleStorage.DisplayMethods();
        }
    }
}

