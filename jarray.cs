using System;

public class jary
{
    public static void Main(string[] args)
    {

        int[][] jAry = new int[4][];
        jAry[0] = new int[4];
        jAry[1] = new int[3];
        jAry[2] = new int[2];
        jAry[3] = new int[1];
        Console.WriteLine("Enter the Array element:");

        for (int i = 0; i < jAry.Length; i++)
        {
            for (int j = 0; j < jAry[i].Length; j++)
            {

                jAry[i][j] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(jAry[i][j]);
            }
        }
        Console.WriteLine("Jagged Array is:");
        for (int i = 0; i < jAry.Length; i++)
        {
            for (int j = 0; j < jAry[i].Length; j++)
            {
                Console.Write(jAry[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}