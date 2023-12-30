namespace VolvoAcademyTask2
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceCoefficient { get; set; }

        public VehicleModel(int id, string name, decimal priceCoefficient) 
        {
            Id = id;
            Name = name;
            PriceCoefficient = priceCoefficient;
        }
    }
}