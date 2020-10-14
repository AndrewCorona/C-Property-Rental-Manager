namespace Property_Rental.Models
{
    public class Property
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public int Bedrooms {get; set;}
        public int Bathrooms {get; set;}
        public int Price {get; set;}
        public int Area {get; set;}
        public string URLImage {get; set;}
        public string Description {get; set;}
        public bool Parking {get; set;}
    }

}