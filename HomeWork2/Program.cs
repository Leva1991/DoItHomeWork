class HomeWork2
{
    static void Main()
    {

        // დავალება 1
         Console.WriteLine("Enter a Number");
         int inputNumber = int.Parse(Console.ReadLine());
         int count = 0;
        for (int i = 1; i <= inputNumber; i++)
         {
             count += i;            
         }
         Console.WriteLine(count);

         // დავალება 2
         Console.WriteLine("Enter a Number");
         int inputNumber2 = int.Parse(Console.ReadLine());
         for (int i = 1;i <= 10; i++)
         {
             Console.WriteLine($"{inputNumber2} * {i} = {inputNumber2*i}");
         } 

        // დავალება 3
        Console.WriteLine("Enter a Number");
        int inputNumber3 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= inputNumber3; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        } 

        // დავალება 4
        Console.WriteLine("Enter a Number");
        int inputNumber4 = int.Parse(Console.ReadLine());
        int count2 = 1;
        for (int i = 1; i <= inputNumber4; i++)
        {
            count2 *= i;
        }
        Console.WriteLine(count2);  

        // დავალება 5
        Console.WriteLine("Enter a Number");
        int inputNumber5 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= inputNumber5; i++)
        {
            for (int j = 1; j <=i; j++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        // დავალება 6

        Console.WriteLine("Enter First Number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int SecondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > SecondNumber)
        {
            for (int i = SecondNumber; i <= firstNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            for (int i = firstNumber; i <= SecondNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}