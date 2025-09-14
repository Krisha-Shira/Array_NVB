using System;

namespace LAB_2
{
    class TwoUniqueNums
    {
        static void Main(string[] args)
        {
            // Example 1 
            int[] arr1 = { 1, 2, 3, 2, 1, 4 };
            Console.Write("Example 1 Output: ");
            FindUniqueNumbers(arr1);

            // Example 2 
            int[] arr2 = { 2, 1, 3, 2 };
            Console.Write("Example 2 Output: ");
            FindUniqueNumbers(arr2);

            Console.ReadLine(); // Keeps console open
        }

        static void FindUniqueNumbers(int[] arr)
        {
            int n = arr.Length;
            bool[] visited = new bool[n];
            int[] unique = new int[2];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (visited[i]) continue;
                int count = 1;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }

                if (count == 1 && k < 2) // Only store up to 2 unique nums
                {
                    unique[k++] = arr[i];
                }
            }

            if (k == 2)
            {
                if (unique[0] < unique[1])
                    Console.WriteLine(unique[0] + " " + unique[1]);
                else
                    Console.WriteLine(unique[1] + " " + unique[0]);
            }
            else
            {
                Console.WriteLine("Less than two unique numbers found.");
            }
        }
    }
}
