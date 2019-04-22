using System;
namespace TriangleCsharp
{
    public class NumberGame
    {
        Random rnd = new Random();
        public NumberGame()
        {
            for (int i = 0; i < 1000000; i++)
            {
				int number = rnd.Next(1, 100);
				Console.Write(number);
            }
        }
    }
}
