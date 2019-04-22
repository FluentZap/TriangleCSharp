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
            NumberGame myGame = new NumberGame();
            Console.WriteLine("Welcome to the thunder dome number guesser");
            Console.WriteLine("If i guess your number you die");
            Console.WriteLine("Think of a number between 1 and 100 and press any key.");
            Console.ReadKey(true);

            bool finish = false;
            int count = 0;
            while (finish == false)
            {
                Console.WriteLine("Is your number higher or lower then: " + myGame.lastGuess);
                Console.WriteLine("1. Higher  2.Lower  3.It is the number");
                ConsoleKeyInfo answer = new ConsoleKeyInfo();
                count++;

                while(answer.Key != ConsoleKey.D1 && answer.Key != ConsoleKey.D2 && answer.Key != ConsoleKey.D3) 
                {
                    answer = Console.ReadKey(true);                    
                }
                switch (answer.Key)
                {
                    case ConsoleKey.D1:
                        myGame.GuessNumber(true);
                        break;
                    case ConsoleKey.D2:
                        myGame.GuessNumber(false);
                        break;
                    case ConsoleKey.D3:
                        if (count < 5) {
							Console.WriteLine("Your Die!");                            
                        } 
                        else
                        {
                            Console.WriteLine("Your Live to fight another day!");                            
                        }
                        finish = true;
                        break;
                    default:

                        break;
                }
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
