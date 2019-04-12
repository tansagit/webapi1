using System;

namespace webapi1.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int InsertId { get; set; }
        public DateTime InsertDate { get; set; }
        public int UpdateId { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Defig { get; set; }
    }
}