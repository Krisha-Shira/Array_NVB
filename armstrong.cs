using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int originalNum = num;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }

        if (sum == originalNum)
            Console.WriteLine(originalNum + " is an Armstrong number.");
        else
            Console.WriteLine(originalNum + " is not an Armstrong number.");
    }
}
