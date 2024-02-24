using System;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {

        //Declare my strings and int variables
        string inputFirstNumber = "";
        string inputSecondNumber = "";
        string inputThirdNumber = "";
        string inputFourthNumber = "";
        string inputFifthNumber = "";

        int myFirstNumber = 0;
        int mySecondNumber = 0;
        int myThirdNumber = 0;
        int myFourthNumber = 0;
        int myFifthNumber = 0;

        //Gets input from user
        Console.WriteLine("Please enter first number");
        inputFirstNumber = Console.ReadLine();
        Console.WriteLine("Please enter second number");
        inputSecondNumber = Console.ReadLine();
        Console.WriteLine("Please enter third number");
        inputThirdNumber = Console.ReadLine();
        Console.WriteLine("Please enter fourth number");
        inputFourthNumber= Console.ReadLine();
        Console.WriteLine("Please enter fifth number");
        inputFifthNumber = Console.ReadLine();

        int.TryParse(inputFirstNumber, out myFirstNumber);
        int.TryParse(inputSecondNumber, out mySecondNumber);
        int.TryParse(inputThirdNumber, out myThirdNumber);
        int.TryParse(inputFourthNumber, out myFourthNumber);
        int.TryParse(inputFifthNumber, out myFifthNumber);

        //Output results for each method 
        var resultOne = Arithmetic.Sum(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("Sum of  all my numbers is " + resultOne);
        Console.WriteLine();

        var resultTwo = Arithmetic.Average(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("Average of first number is " + resultTwo);
        Console.WriteLine();

        var resultThree = Arithmetic.Product(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("Product of first number is " + resultThree);
        Console.WriteLine();

        var resultFour = Arithmetic.LargestNumber(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("LargestNumber of first number is " + resultFour);
        Console.WriteLine();

        var resultFive = Arithmetic.SmallestNumber(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("SmallestNumber of first number is " + resultFive);
        Console.WriteLine();

        var resultSix = Arithmetic.CountOfPositiveIntegers(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("CountOfPositiveIntegers of first number is " + resultSix);
        Console.WriteLine();

        var resultSeven = Arithmetic.CountOfNegativeIntegers(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("CountOfNegativeIntegers of first number is " + resultSeven);
        Console.WriteLine();

        var resultEight = Arithmetic.CountOfZeroes(myFirstNumber, mySecondNumber, myThirdNumber, myFourthNumber, myFifthNumber);
        Console.WriteLine("CountOfZeroes of first number is " + resultEight);
        Console.WriteLine();













    }
       
        
        }

