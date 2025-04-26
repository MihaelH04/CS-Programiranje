using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VubCaffe
{
    public class Consumable
    {
       public Consumable(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}