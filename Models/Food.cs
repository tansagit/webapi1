namespace webapi1.Models
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }

        public virtual Category category { get; set; }
    }
}