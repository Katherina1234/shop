using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_proj.Models
{
    public class Tovar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Brend { get; set; }
        public string Material { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }//худі, пуловер,(види кофт)
        public List<Kind> Kinds { get; set; }
    }
}
