using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VendingMachineApplication.Model
{
   public  class Snack:Product
    {
        public int Calories { get; set; }

        public Snack(string id, string name, int price, int calories)
         : base(id, name, price)
        {
            Calories = calories;
        }
        public override void Examine()
        {
            Console.WriteLine($"snack: {Name}, cost: {Price}kr, calories: {Calories}");
        }

        public override void Use()
        {
            Console.WriteLine($"eat the {Name} snack.");
        }
    }
}
