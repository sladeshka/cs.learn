using Microsoft.VisualBasic;
using System;
using System.IO;
class CopyFileUpper
{
    static void Main()
    {
        Console.Write("Copy from file:");
        string fileFrom = Console.ReadLine();
        Console.Write("Copy to file:");
        string fileTo = Console.ReadLine();
        Console.WriteLine($"Copy from file {fileFrom} to file {fileTo}");
        try
        {
            StreamReader sr  = new(fileFrom);
            StreamWriter sw = new(fileTo);
            while (sr.Peek() != -1)
            {
                sw.WriteLine(sr.ReadLine().ToUpper());
            }
            sw.Close();
            sr.Close();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Input file not found");
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected exception");
            Console.WriteLine(e.ToString());
        }
    }
}