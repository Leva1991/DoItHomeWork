using System;

class HomeWork1
{
    static void Main()
    {
         // დავალება 1
            Console.WriteLine("Enter a number1 : ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number2 : ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            Console.WriteLine(sum);


            // დავალება 2
            Console.WriteLine("Enter a number1 : ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number2 : ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            int result = number3 * number4;
            if (result > 10)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            //დავალება 3
            Console.WriteLine("Enter a number1 : ");
            double number5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number2 : ");
            double number6 = Convert.ToDouble(Console.ReadLine());

            double sum1 = number1 + number2;
            bool isEven;
            if (sum1 % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }

            Console.WriteLine($"sum is {sum1} and isEven is {isEven}");

            // დავალება 4  if else
            Console.WriteLine("Enter a number1 : ");
            double number7 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number2 : ");
            double number8 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter any Operator: [ + - * / ] ");
            string anyOperator = Console.ReadLine();
            double result2;
            if (anyOperator == "+")
            {

                result2 = number7 + number8;
                Console.WriteLine(result2);
            }
            else if (anyOperator == "-")
            {
                result2 = number7 - number8;
                Console.WriteLine(result2);
            }
            else if (anyOperator == "*")
            {
                result2 = number7 * number8;
                Console.WriteLine(result2);
            }
            else if (anyOperator == "/")
            {   
                result2 = number7 / number8;
                Console.WriteLine(result2);
            }

            // Swich
            switch (anyOperator)
            {
                case "+" :
                    result2 = number7 + number8;
                    Console.WriteLine(result2);
                    break;
                case "-" :
                    result2 = number7 - number8;
                    Console.WriteLine(result2);
                    break;
                case "*" :
                    result2 = number7 * number8;
                    Console.WriteLine(result2);
                    break;
                case "/":
                    result2 = number7 / number8;
                    Console.WriteLine(result2);
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;

            }

        // დავალება 5

        Console.WriteLine("Enter a number1 : ");
        double number11 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter a percentage : ");
        double percentage = Convert.ToDouble(Console.ReadLine());

        double result3 = number11 * percentage / 100;
        Console.WriteLine(result3);

        // დავალება 6
        Console.WriteLine("Enter 6 digits number : ");
        int number10 = Convert.ToInt32(Console.ReadLine());

        string numberToString = number10.ToString();
        if (numberToString.Length != 6)
        {
            Console.WriteLine("Error");
        }
        else
        {

            Console.WriteLine("Ented First Position");
            int firsPosition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ented Second Position");
            int secondPosition = Convert.ToInt32(Console.ReadLine());

            char[] charArray = numberToString.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                char temp = charArray[firsPosition - 1];
                charArray[firsPosition - 1] = numberToString[secondPosition - 1];
                charArray[secondPosition - 1] = numberToString[firsPosition - 1];

            }
            string resultString = new string(charArray);
            int resultInt = Convert.ToInt32(resultString);
            Console.WriteLine(resultInt);
        }


        // დავალება 7
        Console.WriteLine("Enter a Temperature : ");
        double number9 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Use Symbol To Measure Temperature :  [C , F ]");
        string symbol = Console.ReadLine();

        if (symbol == "C" || symbol=="c")
        {
            double fahrenheit = (number9 * 9 / 5) + 32;
            Console.WriteLine(fahrenheit);
        }
        else if (symbol == "F" || symbol=="f")
        {
            double celsius = (number9 - 32) * 5 / 9;
            Console.WriteLine(celsius);
        }
        

   

        

        // დავალება 8
    }


}


