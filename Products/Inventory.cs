using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PointOfSalesTerminal
{
    public class Inventory
    {
        public BindingList<Product> productBindingList = new BindingList<Product>();
        private int id;

        public Inventory()
        {
            productBindingList.Add(new Product(++id, "Black Beans", 4.99, 3, "Canned black beans, ready to eat, 10 oz"));
            productBindingList.Add(new Product(++id, "White Rice", 13.99, 10, "Packaged white rice, long-grain, 10 lbs"));
            productBindingList.Add(new Product(++id, "Red Apple", 0.50, 20, "Georgian red apple, organic"));
            productBindingList.Add(new Product(++id, "Tomatoes", 0.99, 54, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Cherry Tomatoes", 0.20, 32, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Yellow Onion", 0.60, 14, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Olive Oil", 2.99, 56, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "White Vinegar", 3.99, 15, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Table Salt", 1.50, 63, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Red Pepper", 0.70, 32, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Sugar", 3.99, 62, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Brown Sugar", 5.50, 72, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "Bottled Water", 4.99, 23, "Organic tomates from California"));
            productBindingList.Add(new Product(++id, "CocaCola", 0.99, 63, "Organic tomates from California"));

        }
        public BindingList<Product> GetList()
        {
            return productBindingList;
        }

        public void AddProduct(Product product)
        {
            Product prod = new Product(++id, product.Name, product.Price, product.Quantity, product.Description);
            productBindingList.Add(prod);
        }

        public void RemoveProduct(Product product)
        {
            productBindingList.Remove(product);
        }

        public Product ElementAt(int index)
        {
            return productBindingList.ElementAt(index);
        }

        public Product FindProductByName(string name)
        {
            Product result = null;
            foreach(Product product in productBindingList)
            {
                if (product.Name == name) result = product;
            }
            return result;
        }
    }
}
