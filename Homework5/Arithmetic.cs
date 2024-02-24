using System;

namespace Homework5
{

    //Methods for calculation
    public static class Arithmetic
    {
        public static int Sum(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            int result = numberOne + numberTwo + numberThree + numberFour + numberFive;
            return result;
            throw new NotImplementedException();
        }

        public static double Average(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            double result = (numberOne + numberTwo + numberThree + numberFour + numberFive) / 5;
            return result;
            throw new NotImplementedException();
        }

        public static int Product(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            int result = numberOne * numberTwo * numberThree * numberFour * numberFive;
            return result;
            throw new NotImplementedException();
        }

        public static int SmallestNumber(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            int smallestNumber =0;
            if (numberOne < numberTwo) 
            {
            smallestNumber= numberOne;
            }
            else if (numberTwo < smallestNumber) 
            { 
            smallestNumber= numberTwo;
            }
            else if (numberThree < smallestNumber)
            { 
                smallestNumber= numberThree;
            }
            else if (numberFour < smallestNumber)
            {
                smallestNumber= numberFour;
            }
            else if (numberFive < smallestNumber) 
            {
                smallestNumber= numberFive;
            }
            return smallestNumber;
            throw new NotImplementedException();
        }

        public static int LargestNumber(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            int largestNumber = 0;
            if (numberOne > numberTwo)
            {
                largestNumber = numberOne;
            }
            else if (numberTwo > largestNumber)
            {
                largestNumber = numberTwo;
            }
            else if (numberThree > largestNumber)
            {
                largestNumber = numberThree;
            }
            else if (numberFour > largestNumber)
            {
                largestNumber = numberFour;
            }
            else if (numberFive > largestNumber)
            {
                largestNumber = numberFive;
            }
            return largestNumber;

            throw new NotImplementedException();
        }

        public static int CountOfPositiveIntegers(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            int count = 0;
            if (numberOne > 0)
            {
                count++;
            }
            if (numberTwo > 0)
            { 
                count++;
            }
            if (numberThree > 0)
            { 
                count++;
            }
            if (numberFour > 0)
            {
                count++;
            }
            if (numberFive > 0)
            {
                count++;
            }
            return count;
            throw new NotImplementedException();
        }

        public static int CountOfNegativeIntegers(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            int count = 0;
            if (numberOne < 0)
            {
                count++;
            }
            if (numberTwo < 0)
            {
                count++;
            }
            if (numberThree < 0)
            {
                count++;
            }
            if (numberFour < 0)
            {
                count++;
            }
            if (numberFive < 0)
            {
                count++;
            }
            return count;
            throw new NotImplementedException();
        }

        public static int CountOfZeroes(int numberOne, int numberTwo, int numberThree, int numberFour, int numberFive)
        {
            int count = 0;
            if (numberOne == 0)
            {
                count++;
            }
            if (numberTwo == 0)
            {
                count++;
            }
            if (numberThree == 0)
            {
                count++;
            }
            if (numberFour == 0)
            {
                count++;
            }
            if (numberFive == 0)
            {
                count++;
            }
            return count;
            throw new NotImplementedException();
        }
    }
}
