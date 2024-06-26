using ConsoleApp;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessGame GuessGameObj = new GuessGame();
            GuessGameObj.guessGame();
            GuessGameObj.squareOfANumber(6);

          
        }
    }
}
