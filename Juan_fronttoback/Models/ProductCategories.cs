using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan_fronttoback.Models
{
    public class ProductCategories
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public Products Products { get; set; }
    }
}
