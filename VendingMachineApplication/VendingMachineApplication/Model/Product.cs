using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApplication.Model
{
   public abstract class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - Price: ${Price:F2} ";
        }
        public abstract void Examine();
       public abstract void Use();
    }
}
