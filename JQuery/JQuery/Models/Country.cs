namespace JQuery.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<State> States { get; }
    }
}
