using System;

class Program
{
    static void Main()
    {
     
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        
        string upperName = name.ToUpper();

        
        Console.WriteLine("Output: " + upperName);
    }
}
