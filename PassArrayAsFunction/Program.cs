using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassArrayAsFunction
{   class MyArray
    {
      public  double getAverage(int[] arr,int size )
        {
            int i;
            int sum = 0;
            double avg;

            for(i= 0; i < size; i++ ) { 
            sum += arr[i];}
            avg = (double)sum / arr.Length;
            return avg;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           int[] balance = new int[]{12,13,24,57,49};

            MyArray myArray = new MyArray();
          double avg = myArray.getAverage(balance,5);
            Console.WriteLine("Average value is: {0} ", avg);
            Console.ReadKey();
            
        }
    }
}
