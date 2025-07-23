using System;

class MaskMobileNumber
{
    static void Main()
    {
        Console.Write("Enter mobile number: ");
        string mobile = Console.ReadLine();

        if (mobile.Length >= 5)
        {
            string masked = mobile.Substring(0, mobile.Length - 5) + new string('X', 5);
            Console.WriteLine("Masked Number: " + masked);
        }
        else
        {
            Console.WriteLine("Mobile number is too short.");
        }
    }
}
