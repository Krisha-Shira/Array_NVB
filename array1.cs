using System;

public class Class1
{
    public static void Main(string[] args)
    {

        int[] ary = new int[5];

        //int[] ary = {10,20,30,40,50};
        //ary[0] = 1;
        //ary[1] = 2;
        //ary[2] = 3;
        //ary[3] = 4;
        //ary[4] = 5;

        //for(int i = 0; i < ary.Length; i++)
        //foreach(int var in ary)

        Console.WriteLine("Enter the array element:");
        for (int i = 0; i < ary.Length; i++)
        {
            ary[i] = int.Parse(Console.ReadLine());



        }
        foreach (int var in ary)
        {
            Console.WriteLine(var);
        }

        int sum = 0;
        for (int i = 0; i < ary.Length; i++)
        {
            sum += ary[i];
        }
        Console.WriteLine(sum);
        Console.WriteLine(sum /= 5);
    }
}