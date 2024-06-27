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
            var result = RandomQuestions.SortAnArray(numbersArray);
            Console.WriteLine(string.Join(",",result));
           

            
            

          
        }
    }
}
