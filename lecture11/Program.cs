namespace lecture11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String filePath = @"C:\Users\levku\Downloads\vehicles.csv";

            String[] text = File.ReadAllLines(filePath);
            for (int i = 0; i < text.Length; i++) 
            {
                if (text[i].Contains("Mercedes-Benz"))
                {
                    Console.WriteLine(text[i]);
                }
            }

           
        }
    }
}
