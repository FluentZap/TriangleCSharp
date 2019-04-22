using System;

namespace TriangleCsharp
{
    class TriangleTest
    {
        public string testTriangle(int sideOne, int sideTwo, int sideThree)
        {
            int longestSide = 0;
            int otherSide = 0;
            if (sideOne > sideTwo && sideOne > sideThree) 
            {
                longestSide = sideOne;
                otherSide = sideTwo + sideThree;
            }
               
            if (sideTwo > sideOne && sideTwo > sideThree)
            {
                longestSide = sideTwo;
                otherSide = sideOne + sideThree;
            }
                
            if (sideThree > sideOne && sideThree > sideTwo)
            {
                longestSide = sideThree;
                otherSide = sideOne + sideTwo;
            }

            if (otherSide < longestSide)
                return "not a triangle";
                

            if (sideOne == sideTwo && sideTwo == sideThree)
            {
                return "This is an Equilateral";
            }

            if (sideOne == sideTwo || sideOne == sideThree || sideThree == sideTwo)
            {
                return "This is an Isosceles";
            }



            return "trianglething";
        }
    }
}