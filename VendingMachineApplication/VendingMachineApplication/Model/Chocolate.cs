using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApplication.Model
{

   public class Chocolate :Product
    {
        public string Flavor { get; set; }
        public Chocolate(string id, string name, int price, string flavor)
         : base(id, name, price)
        {
            Flavor = flavor;
        }

        public override void Examine()
        {
            Console.WriteLine($"chocolate: {Name}, cost: {Price}kr, flavor: {Flavor}");
        }
        public override void Use()
        {
            Console.WriteLine($"enjoy your {Name} chocolate!");
        }
    }
}
