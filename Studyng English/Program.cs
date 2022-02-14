using System;

namespace Studyng_English
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Write a number");

            string number1Txt = Console.ReadLine();

            Console.WriteLine("Write an operator");

            string varOperator = Console.ReadLine();

            Console.WriteLine("Write a number");

            string number2Txt = Console.ReadLine();

            int num1, num2;

            num1 = int.Parse(number1Txt);
            num2 = int.Parse(number2Txt);

            int result;

            if (varOperator.Equals("+"))
            {
                result = num1 + num2;
                Console.WriteLine("your result is: " + result);
            }
            if (varOperator.Equals("-"))
            {
                result = num1 - num2;
                Console.WriteLine("your result is: " + result);
            }
            if (varOperator.Equals("/"))
            {
                result = num1 / num2;
                Console.WriteLine("your result is: " + result);
            }
            if (varOperator.Equals("*"))
            {
                result = num1 * num2;
                Console.WriteLine("your result is: " + result);
            }
            if (varOperator.Equals("*"))
            {
                result = num1 * num2;
                Console.WriteLine("your result is: " + result);
            }

        }
    }
}
