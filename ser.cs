﻿using System;

class FibonacciSeries
{
    static void Main()
    {
        int n = 10;
        int a = 0, b = 1;

        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}
