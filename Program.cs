namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Mata in en siffra");
            string input = Console.ReadLine();
            int sida = Int32.Parse(input);
            //I dessa första rader kod så ber jag användaren mata in sin siffra
            //Jag förvarar inmatningen i variabeln string som jag gör om till en int och döper den till "sida"
            for (int rad = 0; rad < sida; rad++)
            {
                for (int kolumn = 0; kolumn < sida; kolumn++)
                {
                    if ((rad + kolumn) % 2 == 0)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("□");
                    }
                    /*I denna nästlade for-loop så har jag i det yttre lagret gett vilkoret att raden börjar på 0
                     * Och så länge raden är mindre än sidan så ska raden plussa på en.
                     * sedan har jag lagt en till for loop för kolumnen med lika villkor.
                     * och i den så ligger en if-sats som hanterar hur utmatningen ska ske
                     * för att det ska bli varannan så har jag gjort en if-sats där den kollar om rad+kolumn är delbart med 2 
                     * så ska den skriva ut "■", är det inte så skriver den ut "□".
                     */
                }
                Console.WriteLine();
            }
        }
    }
}
