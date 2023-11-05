namespace CHEFMANAGEMENT.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string ProfileImage { get; set; }
    }

    public class Cheff : User
    {
        public List<Cuisine> Specialties { get; set; }
        //public string Specialization { get; set; }
        public int ExperienceYears { get; set; }
        // Additional properties specific to Cheff
    }

    public class Customer : User
    {
        // Additional properties specific to Customer
    }

    public class Driver : User
    {
        public string LicenseNumber { get; set; }
        public bool HasCommercialLicense { get; set; }
        // Additional properties specific to Driver
    }

    public class CuisineType
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Cuisine
    {
        public string FoodName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Ingredients { get; set; }
        public string NutritionalValue { get; set; }
        public CuisineType CuisineType { get; set; }
    }

    public class Order
    {
        public int OrderNo { get; set; }
        public int CheffId { get; set; }
        public decimal TotalOrderPrice { get; set; }
        public int CustomerId { get; set; }
        public int DriverId { get; set; }
    }
}
