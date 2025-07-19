using System;

public class Class1
{
    public static void Main(string[] args)
    {
        int[] ary = new int[6];
        bool[] freq = new bool[ary.Length];

        Console.WriteLine("Enter the array element");
        for (int i = 0; i < ary.Length; i++)
        {
            ary[i] = Int32.Parse(Console.ReadLine());
        }
        for (int i = 0; i < ary.Length; i++)
        {
            if (freq[i] == true)
                continue;

            int cnt = 1;
            for (int j = i + 1; j < ary.Length; j++)
            {
                if (ary[i] == ary[j])
                {
                    freq[j] = true;
                    cnt++;

                }
            }
            Console.WriteLine("Frequency of {0} is {1} time", ary[i], cnt);
        }

    }
}