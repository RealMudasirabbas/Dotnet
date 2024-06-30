using ConsoleApp;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessGame GuessGameObj = new GuessGame();
            RandomQuestions RandomQuestions = new RandomQuestions();
            //GuessGameObj.guessGame();
            //RandomQuestions.PowerOfANumber(6,2);
            //RandomQuestions.AddPy();
            //RandomQuestions.ArmstrongNumber();
            int[] numbersArray = { 66,1,3,5,9,79};
            int[] array = { 4, 5, 8, 12, 23, 68 };
            //RandomQuestions.SortAnArray(numbersArray);
            //RandomQuestions.Factorial();
            //RandomQuestions.DisplayObjProperties();
            //var result = RandomQuestions.filterAnArray(array);
            //Console.WriteLine(string.Join(", ",result));
            //int[] result = RandomQuestions.multipliedArray(array);
            // Console.WriteLine(string.Join(", ", result));
            //var result = RandomQuestions.ReduceArray(array);
            // Console.WriteLine(result);

            string fahrenheitResult = RandomQuestions.CelsiusToFahrenheit(37);
            Console.WriteLine($"The Temperature converted from Celsius to Fahrenheit is: {fahrenheitResult}");

           
            RandomQuestions.AreaAndPerimeterOfaCircle(7);

           
            RandomQuestions.SumOfArray([ 1, 0, 2, 3, 4 ]);

            //RandomQuestions.MultiplyDivide();
            //RandomQuestions.RemoveAChar();
            //RandomQuestions.modifyStr();
            //RandomQuestions.CheckMultiplesOfThreeAndSeven();
            RandomQuestions.FizzBuzz();
            
        }

       






    }
}

