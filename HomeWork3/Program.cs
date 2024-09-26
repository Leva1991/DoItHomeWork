namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3,10,26,37,40,5,2,1,26};

            // დავალება 1
            int sumArrayEvenElements = 0;
            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] % 2 == 0)
                {
                    sumArrayEvenElements += testArray[i];
                }
            }

            Console.WriteLine(sumArrayEvenElements);

            // დავალება 2
            int[] coppyArray = new int[11];
            for (int i = 0; i < testArray.Length; i++)
            {
                coppyArray[i] = testArray[i];
            }

            for (int i = 0; i < coppyArray.Length; i++)
            {
                Console.WriteLine(coppyArray[i]);
            }


            // დავალება 3
            int[] temp = new int[testArray.Length];
            int uniqueCount = 0;
            for (int i = 0; i < testArray.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (testArray[i] == temp[j])
                    {
                        isUnique = false; 
                        break; 
                    }
                }

                if (isUnique)
                {
                    temp[uniqueCount] = testArray[i];
                    uniqueCount++; 
                }
            }
            for (int i = 0; i < temp.Length; i++) 
            {
                Console.WriteLine(temp[i]);
            }

            // დავალება 4
            int temp1 = testArray[0];
            for (int i = 0; i < testArray.Length; i++)
            {

                if (temp1 < testArray[i])
                {
                    temp1 = testArray[i];
                }

            }
            Console.WriteLine(temp1);


            // დავალება 5
            int tempElement = testArray[0];
            int tempIndex = 0;
            for (int i = 0; i < testArray.Length; i++)
            {

                if (tempElement < testArray[i])
                {
                    tempElement = testArray[i];
                    tempIndex = i;
                }

            }
            Console.WriteLine(tempIndex);


            // დავალება 6

            for (int i = 0; i < testArray.Length; i++) 
            {
                for (int j = 0; j < testArray.Length-i-1; j++) 
                {
                    if (testArray[j] > testArray[j + 1])
                    {
                        int temp2 = testArray[j];
                        testArray[j] = testArray[j + 1];
                        testArray[j + 1]= temp2;

                    }
                }
            }
            for (int i = 0;i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i]);
            }
        }
    }
}
