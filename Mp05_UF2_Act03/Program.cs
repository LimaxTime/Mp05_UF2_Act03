internal class Program
{
    public static void ShowOptions()
    {
        Console.Clear();
        Console.WriteLine("WELCOME TO MARC AND JORDI'S QUIZ! NOW CHOOSE A TOPIC:");
        Console.WriteLine("1 - MANGA/ANIME");
        Console.WriteLine("2 - POKEMON");
        Console.WriteLine("3 - INVOICES");
        Console.WriteLine("4 - INVOICES");
        Console.WriteLine("5 - INVOICES");
        Console.WriteLine("6 - INVOICES");
        Console.WriteLine("0 - EXIT");
    }
    static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    mangaAnime();
                    break;
                default:
                    MsgNextScreen("Error. Prem una tecla per tornar al menú...");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    public static void mangaAnime()
    {

    }
}