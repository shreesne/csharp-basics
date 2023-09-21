using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodNew
{
    public class Test
    {
        public static string Formatter(string FirstName, string LastName)
        {
            string last = $"{LastName[0].ToString().ToUpper()}" +$"{LastName.ToLower().Substring(1)}";
            string first = $"{FirstName[0].ToString().ToUpper()}"+$"{FirstName.ToLower().Substring(1)}";
             string third =$"{LastName.Substring(0,3).ToUpper()}"+$"{FirstName.Substring(0,3).ToUpper()}";
            return $"#_{last},{first}({third})";
        }
    }
}
