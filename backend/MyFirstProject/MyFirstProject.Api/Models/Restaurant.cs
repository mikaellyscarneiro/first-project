namespace MyFirstProject.Api.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] PaymentMethods { get; set; }
        public string ImageUrl { get; set; }
        public Contact Contact { get; set; }
    }
}
