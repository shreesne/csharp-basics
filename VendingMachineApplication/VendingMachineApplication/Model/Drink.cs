using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApplication.Model
{
   public class Drink : Product
    {
        public string Flavor { get; set; }

        public Drink(string id, string name, int price, string flavor)
         : base(id, name, price)
        {
            Flavor = flavor;
        }

        public override void Examine()
        {
          
            Console.WriteLine($"{Name} {Price}kr {Flavor}");

        }

        public override void Use()
        {
          
            Console.WriteLine($"Drink your {Name} ! Enjoy !! ");
        }
    }
}
