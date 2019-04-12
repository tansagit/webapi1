using System.Collections.Generic;

namespace webapi1.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}