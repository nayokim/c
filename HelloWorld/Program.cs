using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)


        {
            //DATA TYPES: int, double, char, string, bool
            //  VARIABLES: datatype variableName = value;
            //      COMMON ERRORS: wrong type, wrong value, no semicolon
            //DATA TYPE CONVERSION: implicit, explicit, methods

            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";

            int age = 5;
            double weight = 65.22;
            bool spayed = true;

            // Print variables to the console

            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);



            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your favorite number!: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your favorite number is: " + faveNumber);


        }
    }
}
