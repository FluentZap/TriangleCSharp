using System;
namespace TriangleCsharp
{
    public class NumberGame
    {
        private int Min = 1;
        private int Max = 100;
        public int lastGuess = 0;

        Random rnd = new Random();
        public NumberGame()
        {
			//int number = rnd.Next(1, 100);
            Guess();
        }

        public void GuessNumber(bool isHigher)
        {
            if (isHigher == true)
            {
                if (lastGuess >= Min) Min = lastGuess;
            }
            else
            {
                if (lastGuess <= Max) Max = lastGuess;
            }
            Guess();
        }



        private int Guess() 
        {
            int Range = Max - Min;
            float random = rnd.Next(90, 110) * 0.01f;
            int numberGuess = (int)Math.Floor((Range / 2d) * random) + Min;
            lastGuess = numberGuess;
            return numberGuess;
        }
    }
}
