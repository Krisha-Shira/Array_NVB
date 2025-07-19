using System;

public class Class1
{
    public static void Main(string[] args)
    {
        int[] ary = new int[5];
        //initialization of array element

        Console.WriteLine("Enter the array element:");
        for (int i = 0; i < ary.Length; i++)
        {
            ary[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < ary.Length; i++)
        {

            for (int j = i + 1; j < ary.Length; j++)
            {
                if (ary[i] > ary[j])
                {
                    int temp = ary[i];
                    ary[i] = ary[j];
                    ary[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted array Element:");
        for (int i = 0; i < ary.Length; i++)
        {
            Console.WriteLine(ary[i]);
        }
    }
}