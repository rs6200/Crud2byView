using System.ComponentModel.DataAnnotations;

namespace CHEFMANAGEMENT.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
    }
}
