class lecture3
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        double number1 = double.Parse(Console.ReadLine());


        while (true)
        {
            try
            {

                
                Console.WriteLine("Enter another number");
                double number2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator");
                string imputOperator = Console.ReadLine();


                if (imputOperator == "/")
                {
                    number1 =number1/ number2;
                    Console.WriteLine(number1);
                }
                else if (imputOperator == "-")
                {
                    number1 -= number2;
                    Console.WriteLine(number1);
                }
                else if (imputOperator == "+")
                {
                    number1 += number2;
                    Console.WriteLine(number1);

                }
                else if (imputOperator == "*")
                {
                    number1 *= number2;
                    Console.WriteLine(number1);

                }
                else if (imputOperator == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("use correct operator");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}