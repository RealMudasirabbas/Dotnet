using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class RandomQuestions
    {
        public int PowerOfANumber(int num, int power)
        {
            int squareOfANum = Convert.ToInt32(Math.Pow(num, power));
            Console.WriteLine(squareOfANum);
            return squareOfANum;
        }

        public string AddPy()
        {
            string userInput = Console.ReadLine();
            if (userInput.StartsWith("Py") || userInput.StartsWith("py"))
            {
                Console.WriteLine(userInput);
                return userInput;
            }
            else
            {
                string newStr = "Py" + userInput;
                Console.WriteLine(newStr);
                return newStr;
            }
        }
    }
}
