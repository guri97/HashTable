namespace Day19_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///UC1:Find the frequency of word in sentence
            /// </summary>
            Console.WriteLine("Welcome to Data Structure Problem Using Generics");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);
            string sentence = "to be or not to be";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency = LinkedHashMap.Get("to");
            Console.WriteLine(frequency);



        }
    }
}
