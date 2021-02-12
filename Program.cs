using System;
public class Exercise13 // {r}
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        string number = (Console.ReadLine());

        Console.WriteLine(number + number + number);
        Console.WriteLine(number + " " + number);
        Console.WriteLine(number + " " + number);
        Console.WriteLine(number + " " + number);
        Console.WriteLine(number + number + number);

        // Alternative:

        Console.Write("Enter a number again: ");
        string x = (Console.ReadLine());

        Console.WriteLine("{0}{0}{0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0}{0}{0}",x);

        Console.ReadLine();
    }
}

//Mais testes
