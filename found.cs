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

        int searchEle;
        Console.WriteLine("Enter the element to search:");
        searchEle = Convert.ToInt32(Console.ReadLine());
        int flag = 0;
        for (int i = 0; i < ary.Length; i++)
        {
            if (ary[i] == searchEle)
            {
                flag = 1;
            }
        }
        if (flag == 1)
        {
            Console.WriteLine("element is in array:");
        }
        else
        {
            Console.WriteLine("element is not in array:");
        }

    }
}