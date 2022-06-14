using Juan_fronttoback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan_fronttoback.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Features> Features { get; set; }
        public List<Products> Products { get; set; }
        public List<ProductImages> ProductImages { get; set; }
        public List<Categories> Categories { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
        public List<Color> Colors { get; set; }
        public List<ProductColors> ProductColors { get; set; }
    }
}
