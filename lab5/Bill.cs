using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;



namespace VubCaffe
{
    public class Bill
    {
        public Bill()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public ImmutableList<IProduct> Products
        {
            get => products.ToImmutableList();
        }
        public double Total()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Totalprice();
            }
            return total;
        }
        private List<IProduct> products;

    }

}
