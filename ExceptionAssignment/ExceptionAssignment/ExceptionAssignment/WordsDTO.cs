using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    public class WordsDTO
    {
        public string[] StringArray { get; set; }
        public bool BooleanValue { get; set; }
        public string StringValue { get; set; }

       public static List<int> ExtractAndSortNumbers(string input)
        {
            List<int> numbers = new List<int>();
            string[] numberStrings=input.Split(' ');
 
            foreach (string numString in numberStrings)
            {
                try
                {
                    int number = int.Parse(numString);
                    numbers.Add(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entry discarded");
                }
            }

            numbers.Sort((a, b) => b.CompareTo(a));
            return numbers;
        }
        public static WordsDTO ReadFileAndCreateDTO(string filePath)
        {
          WordsDTO dto = new WordsDTO();

            try
            {
                if (!File.Exists(filePath))
                throw new FileNotFoundException();
                string fileContent = File.ReadAllText(filePath);
                string[] words = fileContent.Split(',');
                dto.StringArray = words;
                dto.BooleanValue = true;
                dto.StringValue = "Success";

            }
            catch(Exception ex)
            {
                dto.BooleanValue = false;
                dto.StringValue = "File Not Found";
            }

            return dto;
        }
    }

}
