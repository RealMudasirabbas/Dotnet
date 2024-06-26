using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class GuessGame
    {
        
        public int generateSecretNumber()
        {
            var randomNumGenerator = new Random();
            var secretNum = randomNumGenerator.Next(1,100);
            return secretNum;
            

        }

        public void guessGame()
        {
            var secretNum = generateSecretNumber();
            Console.WriteLine("Welcome to guess game");
            Console.WriteLine("Enter your guess");


            while (true)
            {

                var userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == secretNum)
                {
                    Console.WriteLine("Congratulations! You won");
                    break;
                }
                else if (userGuess > secretNum)
                {
                    Console.WriteLine("Too big");
                }
                else if (userGuess < secretNum)
                {
                    Console.WriteLine("Too small");
                }
            }
        }

        public double squareOfANumber(int num)
        {
           int squareOfANum = Convert.ToInt32( Math.Sqrt(num));
            Console.WriteLine(squareOfANum);
            return squareOfANum;
        }

        
    }
}
