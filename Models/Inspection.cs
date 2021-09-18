namespace rentCar.Models
{
    public class Inspection
    {
        public int Id { get; set; }
        public int Car { get; set; }
        public int Client { get; set; }
        public bool HasScratches { get; set; }
        public string FuelQuantity { get; set; }
        public bool ReplacementRubber { get; set; }
        public bool HasCat { get; set; }
        public bool GlassBroken { get; set; }
        public bool FrontLeftWheel { get; set; }
        public bool FrontRightWheel { get; set; }
        public bool RearLeftWheel { get; set; }
        public bool RearRightWheel { get; set; }
        public string date { get; set; }
        public int Employee { get; set; }
        public bool able { get; set; }
    }
}