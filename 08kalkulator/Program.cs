using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, x, y;
        Console.WriteLine("Wprowadź pierwszą liczbę");
        a = inputValue();
        Console.WriteLine("Wprowadź drugą liczbę");
        b = inputValue();
        Console.WriteLine("Podaj jakie działanie chcesz wykonać: dodawanie - 1 , odejmowanie - 2, mnożenie -3 oraz dzielenie -4");
        x = inputValue();
        if (x == 1)
        {
            y = a + b;
            Console.WriteLine("Wynik dodawania to: "+y);
            Console.ReadLine();
        }
        else if (x == 2)
        {
            y = a - b;
            Console.WriteLine("Wynik odejmowania to "+y);
            Console.ReadLine();
        }
        else if (x == 3)
        {
            y = a * b;
            Console.WriteLine("Wynik mnożenia to: "+y);
            Console.ReadLine();
        }
        else if (x == 4)
        {
            if (b == 0)
            {
                Console.WriteLine("Wynik to: "+a+"/"+b);
                Console.ReadLine();
            }
            else
            {
                y  = a / b;
                Console.WriteLine("Wynik dzielenia to: "+y);
                Console.ReadLine();
            }
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}