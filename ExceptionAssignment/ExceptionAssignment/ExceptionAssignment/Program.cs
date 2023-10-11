namespace ExceptionAssignment
{
 public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of numbers separated by spaces:");
            string input = Console.ReadLine();

            List<int> sortedNumbers =WordsDTO.ExtractAndSortNumbers(input);

            Console.WriteLine("Sorted numbers (highest to lowest):");
            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("enter a file path with seperated comma :");
            string filePath = Console.ReadLine();
            WordsDTO result = WordsDTO.ReadFileAndCreateDTO(filePath);

            Console.WriteLine("BooleanValue: " + result.BooleanValue);
            Console.WriteLine("StringValue: " + result.StringValue);

            if (result.StringArray != null)
            {
                Console.WriteLine("StringArray:");
                foreach (string word in result.StringArray)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}