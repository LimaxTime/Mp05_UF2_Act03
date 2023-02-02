internal class Program
{
    //JORDI
    public static void ShowOptions()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WELCOME TO MARC AND JORDI'S QUIZ! NOW CHOOSE A TOPIC:");
        Console.WriteLine("1 - MANGA/ANIME");
        Console.WriteLine("2 - POKEMON");
        Console.WriteLine("3 - VIDEOGAMES");
        Console.WriteLine("4 - INVOICES");
        Console.WriteLine("5 - INVOICES");
        Console.WriteLine("6 - INVOICES");
        Console.WriteLine("0 - EXIT");
    }
    //JORDI
    static void Main(string[] args) //OPCIONS DE TECLA
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
                    mangaAnimeOptions11();
                    break;
                case ConsoleKey.D2:
                    pokemonOptions11();
                    break;
                case ConsoleKey.D3:
                    videogamesOptions11();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
   
    //JORDI
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
    //JORDI
    public static void fail()
    {
        Console.WriteLine("YOU FAILED");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void mangaAnimeOptions1()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE MANGA/ANIME IP THAT GENERATES MORE MONEY?");
        Console.WriteLine("1 - DRAGON BALL");
        Console.WriteLine("2 - ONE PIECE");
        Console.WriteLine("3 - NARUTO");
        Console.WriteLine("4 - BIBLE BLACK");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void mangaAnimeOptions11()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            mangaAnimeOptions1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    mangaAnimeOptions22();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void mangaAnimeOptions2()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS NARUTO'S AUTHOR?");
        Console.WriteLine("1 - TAKESHI OBATA");
        Console.WriteLine("2 - ONICHI CHI");
        Console.WriteLine("3 - MASASHI KISHIMOTO");
        Console.WriteLine("4 - SATOJI TAJIRI");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void mangaAnimeOptions22()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            mangaAnimeOptions2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    mangaAnimeOptions33();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void mangaAnimeOptions3()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS THE FIRS TO GET A DEATH NOTE FROM A SHINIGAMI IN DEATH NOTE?");
        Console.WriteLine("1 - LIGHT YAGAMI");
        Console.WriteLine("2 - L");
        Console.WriteLine("3 - HIPHOP");
        Console.WriteLine("4 - MATSUDA");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void mangaAnimeOptions33()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            mangaAnimeOptions3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    mangaAnimeOptions44();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void mangaAnimeOptions4()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO TURNS INTO GHOUL IN TOKYO GHOUL?");
        Console.WriteLine("1 - LIMAX TIME");
        Console.WriteLine("2 - SHINRA KUSAKABE");
        Console.WriteLine("3 - NARUTO UZUMAKI");
        Console.WriteLine("4 - KEN KANEKI");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void mangaAnimeOptions44()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            mangaAnimeOptions4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    mangaAnimeOptions55();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void mangaAnimeOptions5()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS A HUMAN IN GODDESS?");
        Console.WriteLine("1 - LYNNA");
        Console.WriteLine("2 - LIMAX");
        Console.WriteLine("3 - ZEUS");
        Console.WriteLine("4 - LUCH");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void mangaAnimeOptions55()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            mangaAnimeOptions5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //-----------------------------------------POKEMON-----------------------------------------------------------------------
    //JORDI
    public static void pokemonOptions1()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS THE FIRS LEGENDARY TO APEAR IN THE ANIME?");
        Console.WriteLine("1 - MOLTRES");
        Console.WriteLine("2 - HO-HO");
        Console.WriteLine("3 - LUGIA");
        Console.WriteLine("4 - ARTICUNO");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void pokemonOptions11()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            pokemonOptions1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    pokemonOptions22();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void pokemonOptions2()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS THE ANIME PROTAGONIST?");
        Console.WriteLine("1 - RED");
        Console.WriteLine("2 - HILDA");
        Console.WriteLine("3 - ASH");
        Console.WriteLine("4 - SATOJI TAJIRI");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void pokemonOptions22()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            pokemonOptions2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    pokemonOptions33();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void pokemonOptions3()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS FROM FIRE TYPE?");
        Console.WriteLine("1 - CHARMANDER");
        Console.WriteLine("2 - BULBASAUR");
        Console.WriteLine("3 - SQUIRTLE");
        Console.WriteLine("4 - OSHAWOT");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void pokemonOptions33()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            pokemonOptions3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    pokemonOptions44();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void pokemonOptions4()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHAT TYPE IS STRONG IN FRONT OF WATER?");
        Console.WriteLine("1 - FIRE");
        Console.WriteLine("2 - DRAGON");
        Console.WriteLine("3 - GROUND");
        Console.WriteLine("4 - PLANT");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void pokemonOptions44()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            pokemonOptions4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    pokemonOptions55();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void pokemonOptions5()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO WAS THE FIRST POKEMON OF ASH?");
        Console.WriteLine("1 - CHARMANDER");
        Console.WriteLine("2 - SNIVY");
        Console.WriteLine("3 - CATERPIE");
        Console.WriteLine("4 - PIKACHU");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void pokemonOptions55()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            pokemonOptions5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //-------------------------------------------------------------------------VIDEOGAMES-----------------------------------------------------------
    //JORDI
    public static void videogamesOptions1()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS THE FIRST FEMENINE PLAYABLE CHARACTER IN VIDEOGAMES?");
        Console.WriteLine("1 - TIFA LOCKHART");
        Console.WriteLine("2 - SAMUS ARAN");
        Console.WriteLine("3 - ALOY");
        Console.WriteLine("4 - PRINCESS PEACH");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void videogamesOptions11()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            videogamesOptions1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    videogamesOptions22();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void videogamesOptions2()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE MOST SELLED CONSOLE OF ALL TIME?");
        Console.WriteLine("1 - PLAY STATION 4");
        Console.WriteLine("2 - NINTENDO SWITCH");
        Console.WriteLine("3 - PLAY STATION 2");
        Console.WriteLine("4 - NINTENDO DS");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void videogamesOptions22()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            videogamesOptions2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    videogamesOptions33();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void videogamesOptions3()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO EXTERMINED ALL THE FLOOD");
        Console.WriteLine("1 - MASTER CHIEF");
        Console.WriteLine("2 - SAMUS ARAN");
        Console.WriteLine("3 - KRATOS");
        Console.WriteLine("4 - MARIO");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void videogamesOptions33()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            videogamesOptions3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    videogamesOptions44();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void videogamesOptions4()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHAT ZELDA IS AN OPENWORLD GAME?");
        Console.WriteLine("1 - TWILIGHT PRINCESS");
        Console.WriteLine("2 - WIND WAKER");
        Console.WriteLine("3 - PHANTOM HOURGLASS");
        Console.WriteLine("4 - BREATH OF THE WILD");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void videogamesOptions44()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            videogamesOptions4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    videogamesOptions55();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //JORDI
    public static void videogamesOptions5()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE MOST SELLED VIDEOGAME?");
        Console.WriteLine("1 - TETRIS");
        Console.WriteLine("2 - PAC-MAN");
        Console.WriteLine("3 - GTA V");
        Console.WriteLine("4 - MINECRAFT");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }
    //JORDI
    public static void videogamesOptions55()//OPCIONS DE TECLA
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            videogamesOptions5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
}
