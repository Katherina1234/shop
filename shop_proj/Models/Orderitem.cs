using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_proj.Models
{
    public class Orderitem
    {
        public int Id { get; set; }
        public User Order { get; set; }
        public string OrderId { get; set; }
        public Size Size { get; set; }
        public int SizeId { get; set; }
    }
}
