using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_proj.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tovar> Tovars { get; set; }
    }
}
