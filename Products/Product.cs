using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PointOfSalesTerminal
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product(int id, string name, double price, int quantity, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;
        }

        //Overloaded constructor without id, used for ID auto-generation
        public Product(string name, double price, int quantity, string description)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;
        }


    }

}