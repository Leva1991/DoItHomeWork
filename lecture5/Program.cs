namespace lecture5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 2, 3, 5, 6 };
            string[] numberArray1 = { "gsga","ssad" };
            findArrayLastElement(numberArray);
            findArrayLastElement(numberArray1);
        }


        static void findArrayLastElement<T>(T[] array1)
        {

            int index = array1.Length-1;
            Console.WriteLine(array1[index]);
        }
    }
}
