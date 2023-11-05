namespace FirstWeb.Models
{
    public class CustomerUser
    {
        public int Id { get; set; }
        //public int ApplicationUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureStoragePath { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
