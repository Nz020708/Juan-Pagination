using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan_fronttoback.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductColors> ProductColors { get; set; }
    }
}
