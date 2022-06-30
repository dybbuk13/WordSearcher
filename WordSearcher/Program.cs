namespace WordSearcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listofwords = new List<string> { "test", "test", "another word" };
            Console.Write("What word are you looking for?");
            string testWord = Console.ReadLine();

            int i = 0;
            foreach (string word in listofwords)
            {
               if (word.ToUpper() == testWord.ToUpper())
                {
                    i++;
                }
            }
            Console.WriteLine(testWord + " showed up " + i + " times!");
        }
    }
}