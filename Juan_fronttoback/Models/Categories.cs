using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan_fronttoback.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Namw { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }
    }
}
