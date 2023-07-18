using System;
namespace Doviz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("USD to UZS");
            Console.Write("Enter Amount USD: ");
            decimal USD = decimal.Parse(Console.ReadLine());
            System.Console.WriteLine("Converting from USD to UZS...");
            decimal UZS =  11607 * USD;
            Console.WriteLine($"{USD} USD = {UZS} UZS");
            
        }
    }
}