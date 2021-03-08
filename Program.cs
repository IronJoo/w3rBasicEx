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
            //first character = str.Substring(0, 1);
            //last character = str.Substring(str.Length-1);
            //middle characters  = str.Substring(1, str.Length-2);

                   //if:            do:                                                                                      else:
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
