using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y;
        Console.WriteLine("Podaj liczbę pierwszą");
        x = inputValue();
        Console.WriteLine("Podaj liczbę drugą");
        y = inputValue();

        if (x == y)
        {
            Console.WriteLine("Liczby są takie same");
            Console.ReadLine();
        }
        else if (x > y)
        {
            Console.WriteLine("Większa jest liczba: " + x);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Większa jest liczba: " + y);
            Console.ReadLine();
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