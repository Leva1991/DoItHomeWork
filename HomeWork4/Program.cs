using System.Linq;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter Text");
            string inputText = Console.ReadLine();
            Console.WriteLine(countStringSize(inputText)); 
            int[] inputArray = { 1, 2, 3, 4, 5, 45, 6, 7, 8, 70, 1, 1, 9 };
            sortArrayAsc(inputArray); */
            // Console.WriteLine(all("aaaaa aaaaaa", 'a'));
            string inputText = "today is a good day for walking. i will try to walk near the sea";
            // Console.WriteLine(firstLetterUpperCase(inputText));
            firstLetterUpperCase(inputText);
        }

        //function 1
        static int countStringSize(string inputText)
        {
            int size = inputText.Length;
            return size;

        }

        // function 2
        static int sumArrayElements(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }
            return sum;
        }

        // function 3
        static int sumArrayOddElements(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 != 0)
                    sum += inputArray[i];
            }
            return sum;
        }

        // function 4
        static int sumTwoInputInt(int firsNumber, int secondNumber)
        {
            int sum = 0;
            sum = firsNumber + secondNumber;
            return sum;
        }

        // function 5
        static int findArrayMaxElement(int[] inputArray)
        {
            int maxElement = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > maxElement)
                {
                    maxElement = inputArray[i];
                }
            }
            return maxElement;
        }
        // function 6
        static void findInputElementInArray(int[] inputArray, int inputNumber)

        {
            bool findElement = true;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputNumber)
                {
                    Console.WriteLine($"{inputNumber} was found");
                    findElement = false;
                }

            }
            if (findElement)
            {
                Console.WriteLine($"{inputNumber} can't found");
            }
        }

        // function 7
        static void sortArrayAsc(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        int temp2 = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp2;

                    }
                }
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
        }

        // function 8
        static bool containsChar(string Text, char inputChar) 
        {
            bool findElement = true;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == inputChar)
                {
                    findElement = false;
                }

            }
            if (findElement)
            {
              return false;
            }
            return true;
        }

        // function 9
        static bool all(string Text, char inputChar)
        {
            int counter = 0;
            int arraySize = Text.Length;
            for (int i = 0; i < arraySize; i++)
            {
                if (Text[i] == inputChar)
                {
                    counter++;
                }

            }
            if (counter==arraySize)
            {
                Console.WriteLine(counter);
                return true;
            }
            Console.WriteLine(counter);
            return false;
        }

        // string 1
        static void firstLetterUpperCase(string inputText) 
        {
           string[] text = inputText.Split('.');
            for (int i = 0; i < text.Length; i++) 
            {
                string temp = text[i].Trim();
                
                Console.WriteLine(char.ToUpper(temp[0]) + (temp).Substring(1));
                //Console.WriteLine(text[i]);
            }
            
        }
    }
}
