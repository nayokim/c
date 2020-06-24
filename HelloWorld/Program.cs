using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your favorite number!: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your favorite number is: " + faveNumber);
        }
    }
}
