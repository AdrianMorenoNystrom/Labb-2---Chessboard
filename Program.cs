namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Mata in en siffra");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            for (int i = 0; i < number; i++)
            {
                Console.Write("■");
                Console.Write("□");
            }

        }
    }
}