using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VubCaffe
{
   public class Deserti : Consumable, IProduct
    {
        public Deserti(string name, double weight, double price) : base(name)
        {
            Weight = weight;
            Price = price;
        }
        public virtual double Totalprice()
        {
            return Price;
        }
        public override string ToString()
        {
            return string.Format("{0} ({1}g) - {2:0.00}€", Name, Weight, Price);
        }
        public double Weight { get; set; }
        public double Price { get; set; }
    }
}
