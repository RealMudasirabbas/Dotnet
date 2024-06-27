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
            string userInput = Console.ReadLine()!;
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

        public int ArmstrongNumber()
        {
            Console.WriteLine("Write atleast three digits number: ");
            string userInput = Console.ReadLine();
            int num1 = Convert.ToInt32(userInput[0].ToString());
            int num2 = Convert.ToInt32(userInput[1].ToString());
            int num3 = Convert.ToInt32(userInput[2].ToString());

            int num1Cube = Convert.ToInt32(Math.Pow(num1, 3));
            int num2Cube = Convert.ToInt32(Math.Pow(num2, 3));
            int num3Cube = Convert.ToInt32(Math.Pow(num3, 3));
            int Sum = num1Cube + num2Cube + num3Cube;

            if (Sum == int.Parse(userInput))
            {
                Console.WriteLine("Yes, Its an Armstrong number");

            }
            else
            {
                Console.WriteLine("No, It is not an Armstrong number");

            }
            return 0;
        }

        public int[] SortAnArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));

            return arr;

        }
    



        public void Factorial()
        {
            Console.WriteLine("Enter your number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
                int result = 1;
            for (int i = 1; i <= userInput; i++) { 
                result *= i;
            }
            Console.WriteLine($"The factorial of this number {userInput} is: {result}");

        }

        public void DisplayObjProperties()
        {
            Dictionary<string, object> Person = new Dictionary<string, object>();
            Person.Add("Name", "Mudasir");
            Person.Add("Age", 20);
            Person.Add("Education", "Fsc");

            foreach(var prop in Person.Keys)
            {
                Console.WriteLine($"The {prop} of this Person: {Person[prop]}");
            }
        }

        public int[] filterAnArray(int[] arr)
        {
            int[] result = arr.Where(num => num % 2 == 0).ToArray();
            return result;
        }

        public int[] multipliedArray(int[] arr)
        {
            int[] result = arr.Select(num => num * 2).ToArray();
            return result;
        }

        public static int ReduceArray(int[] arr)
        {
            int result = 0;
            result = arr.Aggregate(0,(total,num) => total + num);
            return result;
        }
     
    }

    

    
        
     
}
   

