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



        static void Main(string[] args)
        {
            //TestTriangles();
            TestPalindromes();

        }
    }
}
