namespace testshree
{
    internal class Program
    {
        public static Dictionary<TKey, TValue> JoinDictionaries<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2, bool overwriteExistingKeys = true)
        {
            Dictionary<TKey, TValue> result = new Dictionary<TKey, TValue>(dict1);

            foreach (var kvp in dict2)
            {
                if (result.ContainsKey(kvp.Key))
                {
                    if (overwriteExistingKeys)
                    {
                        result[kvp.Key] = kvp.Value; // Overwrite the existing value with the new value
                    }
                    // If you want to merge values instead of overwriting, you can add custom logic here
                }
                else
                {
                    result[kvp.Key] = kvp.Value;
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 3 }
        };

            Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "B", 4 },
            { "D", 5 }
        };

            Dictionary<string, int> joinedDict = JoinDictionaries(dict1, dict2);

            foreach (var kvp in joinedDict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}