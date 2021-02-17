using System;

namespace w3exercises //{}
{
    class Exercise15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insert a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("You inserted the word {0}.\nSome characters will be removed.", word);
            Console.WriteLine(remove_char(word, 1));
            Console.WriteLine(remove_char(word, word.Length-1));
            Console.WriteLine(remove_char(word, 0));
            Console.ReadLine();
        }

        static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
