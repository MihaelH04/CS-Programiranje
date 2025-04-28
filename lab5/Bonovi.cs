using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubCaffe
{
   public class Bonovi : Consumable, IProduct
    {
        public Bonovi(string name, double price) : base(name)
        {
            Price = price;
        }
        public double Totalprice()
        {
            return Price;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1:0.00}€", Name, Price);
        }
        public double Price { get; set; }
    }
}
