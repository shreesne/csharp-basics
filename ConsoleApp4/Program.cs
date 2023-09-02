using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Program
    {

        static void Main(string[] args)
        {
            ArrayList list= new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //list.Remove(1);
            Console.WriteLine(list.Count);

            ArrayList list2 = new ArrayList();
            list2.Add(10);
            list2.Add(21);
            list2.Add(31);
            
            ArrayList list3 = new ArrayList();
             list3.Add("cat");
            list3.Add("dog");
            list3.Add("monkey");

            list.AddRange(list2);
            list.AddRange(list3);
            list.RemoveAt(0);
            list.Insert(0, "start");
            list.RemoveRange(0, 3);
            Example(list);
           
            //list[i] as string
            //GetRange
            //list.IndexOf

        }

        public static void Example(ArrayList list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
              
                Console.ReadKey();
            }
        }
    }
}
