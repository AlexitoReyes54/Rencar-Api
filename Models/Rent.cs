namespace rentCar.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public int Employee { get; set; }
        public int Car { get; set; }
        public int Client { get; set; }
        public string RentDate { get; set; }
        public string RentReturn { get; set; }
        public int PricePerDay { get; set; }
        public string DaysAmount { get; set; }
        public string Comment { get; set; }
        public bool able { get; set; }
    }
}