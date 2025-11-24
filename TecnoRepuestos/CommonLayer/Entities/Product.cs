using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public string ImgPath { get; set; }
    }
}
