using System;

namespace w3exercises //{}
{
    class Exercise16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insert a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("You inserted the word {0}.\nThe first and last letters will change positions:", word);
            Console.WriteLine(change_char(word));
            Console.ReadLine();
        }

        static string change_char(string str)
        {
            string firstchar = str.Substring(0, 1);
            string lastchar = str.Substring(str.Length-1);
            string middlechar = str.Substring(1, str.Length-2);

            return lastchar + middlechar + firstchar;
        }
    }
}
