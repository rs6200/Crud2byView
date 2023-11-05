using System.ComponentModel.DataAnnotations;

namespace FirstWeb.Models
{
    public class ApplicationUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDateTimeUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDateTimeUtc { get; set; } = DateTime.UtcNow;
        public ICollection<CustomerUser> CustomerUsers { get; set; }

    }
}
