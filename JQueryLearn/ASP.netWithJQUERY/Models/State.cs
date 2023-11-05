namespace ASP.netWithJQUERY.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public virtual Country Country { get; set; }
    }
}
