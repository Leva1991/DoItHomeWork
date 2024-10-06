namespace lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 5, 124, 5, 61, 7, 8 };
            //sortArrayAsc(testArray);
            //Console.WriteLine(findElement(testArray, 5555));
            //Console.WriteLine(findLastIndex(testArray,1));
           
        }


        static void sortArrayAsc(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
        }

        static int findElement(int[] inputArray, int element) 
        {
            
            for (int i = 0; i < inputArray.Length; i++)
            {
              if(inputArray[i]==element)
                {
                  return element;
                }
            }
             return default;
        }

        static int findLastIndex(int[] inputArray, int element) 
        {
           
            for (int i = inputArray.Length -1; i >= 0; i--)
            {

                if (inputArray[i] == element)
                {
                    return i;
                }
               
            }

            return -1;             
                 
           }

        static int[] reverseArray(int[] inputArray) 
        {
            int[] tempArray= new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++) 
            {
                tempArray[i]= inputArray[inputArray.Length-1-i];
            }
            inputArray= tempArray;

            return tempArray;
            
        }

        static int[] findAllElement(int[] inputArray, int element) 
        {
            int count = 0;
            
            for (int i = 0; i < inputArray.Length; i++) 
            {
                if(inputArray[i]==element) {
                    count++;
                }
            }

            int[] tempArray = new int[count];

            for (int i = 0; i < inputArray.Length; i++)
            {
                
                if (inputArray[i] == element)
                {
                    count++;
                }
            }


            return newArray;
        }
            
        
    }
}
