using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan_fronttoback.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DiscountPercent { get; set; }
        public int Description { get; set; }
        public bool IsInStock { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsNew { get; set; }
        public ICollection<ProductImages> Images{ get; set; }
        public ICollection<ProductColors> ProductColors{ get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }
    }
}
