using System;
class Program
{
    static void Main(string[] args)
    {
        string myName;
        Console.WriteLine("Please enter your name");
        myName = Console.ReadLine();
        Console.WriteLine("Hello, {0}", myName);
        Console.ReadLine(); // fix for show message after enter text
    }
}
