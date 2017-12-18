using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Santavolpe.Models
{
    public class Orders
    {

        public List<Santavolpe.Order> EntityList { get; set; }
        public List<Toy> ToyList { get; set; }
        public decimal TotalCost { get; set; }
    }
}