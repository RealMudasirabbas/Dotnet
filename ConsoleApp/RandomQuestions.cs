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
            for (int i = 1; i <= userInput; i++)
            {
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

            foreach (var prop in Person.Keys)
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
            result = arr.Aggregate(0, (total, num) => total + num);
            return result;
        }

        public static string CelsiusToFahrenheit(int celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit + " F";
        }


        public static void AreaAndPerimeterOfaCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"The Area of a circle and perimeter are {area} , {perimeter} respectively");
        }

        public static void SumOfArray(int[] arr)
        {
            int sum = arr.Sum();
            Console.WriteLine(sum);
        }
        public void MultiplyDivide()
        {

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());



            static double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            static double Divide(double num1, double num2)
            {
                return num1 / num2;
            }


            Console.WriteLine($"The result of multiplication is: {Multiply(num1, num2)}");
            Console.WriteLine($"The result of division is: {Divide(num1, num2)}");

        }

        public void RemoveAChar()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter a character to remove: ");
            char charToRemove = Console.ReadLine()[0];


            static string RemoveCharacter(string str, char character)
            {
                return str.Replace(character.ToString(), string.Empty);
            }

            Console.WriteLine("Here is the modified string: " + RemoveCharacter(input, charToRemove));
        }

        public void modifyStr()
        {


            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            static string ModifyString(string str)
            {
                if (str.Length < 2)
                {
                    return str;
                }

                char firstChar = str[0];
                char lastChar = str[-1];
                string middle = str.Substring(1, str.Length - 2);

                return lastChar + middle + firstChar;
            }

            Console.WriteLine("Here is the modified string: " + ModifyString(input));
        }

        public void CheckMultiplesOfThreeAndSeven()
        {
            Console.Write("Enter a positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            static void CheckMultiple(int num)
            {
                if (num < 0)
                {
                    Console.WriteLine("Please provide a positive number.");
                }
                else if (num % 3 == 0 && num % 7 == 0)
                {
                    Console.WriteLine("Yes! It is a multiple of 3 and 7.");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Yes, it is a multiple of 3.");
                }
                else if (num % 7 == 0)
                {
                    Console.WriteLine("Yes, it is a multiple of 7.");
                }
                else
                {
                    Console.WriteLine("It is not a multiple of either 3 or 7.");
                }
            }

            CheckMultiple(num);
        }

        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }



    

    

    
        
     
}
   

