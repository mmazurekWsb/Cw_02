using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga, wzrost, bMI;

        Console.WriteLine("Podaj wage");
        waga = inputValue();
        Console.WriteLine("Podaj wzrost");
        wzrost = inputValue();
        bMI = waga / (wzrost * wzrost);
        Console.WriteLine("Body Mass Index" + bMI);
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
