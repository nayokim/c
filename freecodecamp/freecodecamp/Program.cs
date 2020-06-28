using System;

namespace freecodecamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /  |");
            Console.WriteLine("  /   |");
            Console.WriteLine(" /____|");


            //method overloading
            SayHi();
            SayHi("Nayoung");
            SayHi("Ed");
            SayHi("Ed", 35);

            Console.WriteLine(cube(2));

            //if/else statements
            //bool isFemale = true;
            bool isFemale = false;
            bool isTall = true;
            if (isFemale || isTall)
            {
                Console.WriteLine("You are a tall female");
            } else
            {
                Console.WriteLine("You are not a female");
            }

            Console.ReadLine(); // keeps console window up until line of text is entered. 
        }

        //using methods in c# - capitalize first letter of each word

        static void SayHi()
        {

            Console.WriteLine("Hello user");
        }
        static void SayHi(String name)
        {

            Console.WriteLine("Hello " + name);
        }

        static void SayHi(String name, int age)
        {

            Console.WriteLine("Hello " + name + ", you are : " + age) ;
        }


        // using return statements
        //2^3 = 2*2*2
        static int cube(int num)
        {
            int result = num * num * num;
            return result;

        }

        //using comparisons
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result; 
        }

    }
}
