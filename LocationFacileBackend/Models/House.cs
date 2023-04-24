namespace LocationFacileBackend.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public string GPSCoord { get; set; }
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public int ParkingSpotsCount { get; set; }
        public double Surface { get; set; }
        public bool PetsAllowed { get; set; }
        public int HouseholdsCount { get; set; }
        public int FloorCount { get; set; }
        public int FloorNumber { get; set; }
        public string[] Images { get; set; }

    }
}
