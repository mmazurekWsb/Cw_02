﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        a = inputValue();
        b = inputValue();
        c = inputValue();
        double sredniaArytmetyczna;

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("Sredniaarytmetyczna wynosi "+ sredniaArytmetyczna);
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
