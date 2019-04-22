using System;

namespace TriangleCsharp
{
    class Program
    {
        static void TestTriangles()
        {
            TriangleTest testthing = new TriangleTest();

            Console.WriteLine("Welcone to triangle tester! Enter the first side: ");
            int sideOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side length: ");
            int sideTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side length: ");

            int sideThree = int.Parse(Console.ReadLine());

            string triangle = testthing.testTriangle(sideOne, sideTwo, sideThree);
            Console.WriteLine(triangle);
        }



        static void TestPalindromes()
        {
            Palindromes pal = new Palindromes();

            Console.WriteLine("Welcone to Palindrome tester, enter your Palindrome: ");
            string text = Console.ReadLine();
            Console.WriteLine(pal.CheckForPalindromes(text));
        }

        static void TestNumberGame()
        {
            Console.WriteLine("Welcome to the thunder dome number guesser");
            Console.WriteLine("If i guess your number you die");

            Console.Write("Is your number higher or lower then: ");
            Console.WriteLine("1. Higher  2.Lower  3.It is the number");
            ConsoleKeyInfo answer = Console.ReadKey(true);

            switch (answer.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("One");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Two");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Three");
                    break;
            }
        }

		static void Main(string[] args)
		{
			//TestTriangles();
			//TestPalindromes();
			TestNumberGame();
			
		}

    }
}
