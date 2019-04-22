using System;

namespace TriangleCsharp
{
    
    class Program
    {
        static void Main(string[] args)
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
    }
}
