using System;

public class MyProgram
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Podaj pole koła"); 
        double p, r, obwod;

        p = inputValue();
        r = Math.Sqrt(p / Math.PI);
        obwod = 2 * Math.PI * r;
        Console.WriteLine("Obwód wynosi: "obwod);
        Console.ReadKey();
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