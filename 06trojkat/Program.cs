using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Podaj pierwszy bok");
        a = inputValue();
        Console.WriteLine("Podaj drugi bok");
        b = inputValue();
        Console.WriteLine("Podaj trzeci bok");
        c = inputValue();
        if (a == b && b == c && c == a)
        {
            Console.WriteLine("Z podane boki tworza trojkat rownoboczny");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Z podanych boków nie mozna utworzyć trójkąta równobocznego");
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