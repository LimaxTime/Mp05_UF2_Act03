internal class program
{
    //JORDI
    public static void ShowOptions()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WELCOME TO MARC AND JORDI'S QUIZ! NOW CHOOSE A TOPIC:");
        Console.WriteLine("1 - MANGA/ANIME");
        Console.WriteLine("2 - POKEMON");
        Console.WriteLine("3 - VIDEOGAMES");
        Console.WriteLine("4 - DOOM");
        Console.WriteLine("5 - HALO");
        Console.WriteLine("6 - HOLLOW KNIGHT");
        Console.WriteLine("0 - EXIT");
    }
    //JORDI
    public static void Main() //OPCIONS DE TECLA
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
                case ConsoleKey.D4:
                    DOOM11();
                    break;
                case ConsoleKey.D2:
                    pokemonOptions11();
                    break;
                case ConsoleKey.D3:
                    videogamesOptions11();
                    break;
                case ConsoleKey.D5:
                    HaloOptions11();
                    break;
                case ConsoleKey.D6:
                    HoloOptions11();
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
        Console.WriteLine("2 - ONE PIECE");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    mangaAnimeOptions22();//CORRECT ANSWER
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("3 - MASASHI KISHIMOTO");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    mangaAnimeOptions33();//CORRECT ANSWER
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("1 - LIGHT YAGAMI");//CORRECT ANSWER
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
                    mangaAnimeOptions44();//CORRECT ANSWER
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("4 - KEN KANEKI");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    mangaAnimeOptions55();//CORRECT ANSWER
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
        Console.WriteLine("4 - LUCH");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");//CORRECT ANSWER
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    //-----------------------------------------POKEMON-----------------------------------------------------------------------lol
    //JORDI
    public static void pokemonOptions1()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHO IS THE FIRS LEGENDARY TO APEAR IN THE ANIME?");
        Console.WriteLine("1 - MOLTRES");
        Console.WriteLine("2 - HO-HO");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    pokemonOptions22();//CORRECT ANSWER
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("3 - ASH");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    pokemonOptions33();//CORRECT ANSWER
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("1 - CHARMANDER");//CORRECT ANSWER
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
            pokemonOptions3();//CORRECT ANSWER
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    pokemonOptions44();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("4 - PLANT");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    pokemonOptions55();//CORRECT ANSWER
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
        Console.WriteLine("4 - PIKACHU");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");//CORRECT ANSWER
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("2 - SAMUS ARAN");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    videogamesOptions22();//CORRECT ANSWER
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("3 - PLAY STATION 2");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    videogamesOptions33();//CORRECT ANSWER
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("1 - MASTER CHIEF");//CORRECT ANSWER
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
                    videogamesOptions44();//CORRECT ANSWER
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
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
        Console.WriteLine("4 - BREATH OF THE WILD");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    videogamesOptions55();//CORRECT ANSWER
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
        Console.WriteLine("4 - MINECRAFT");//CORRECT ANSWER
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
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");//CORRECT ANSWER
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    // DOOM
    public static void DOOM1()
    {
        Console.Clear();
        Console.WriteLine("WHEN WAS THE FIRST DOOM LAUNCHED TO MARKET?");
        Console.WriteLine("1 - 1995");
        Console.WriteLine("2 - 1998");
        Console.WriteLine("3 - 1993");
        Console.WriteLine("4 - 2002");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM11()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            DOOM1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    DOOM22();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void DOOM2()
    {
        Console.Clear();
        Console.WriteLine("HOW MANY EPISODES DOES DOOM 2 HAVE?");
        Console.WriteLine("1 - 1");
        Console.WriteLine("2 - 2");
        Console.WriteLine("3 - 3");
        Console.WriteLine("4 - 4");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM22()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            DOOM2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    DOOM33();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void DOOM3()
    {
        Console.Clear();
        Console.WriteLine("WHICH IS THE MOST POWERFULL WEAPON ON DOOM?");
        Console.WriteLine("1 - BFG");
        Console.WriteLine("2 - ROCKER LAUNCHER");
        Console.WriteLine("3 - PISTOL");
        Console.WriteLine("4 - CHAINSAW");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM33()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            DOOM3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DOOM44();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void DOOM4()
    {
        Console.Clear();
        Console.WriteLine("WHAT DO YOU FIGHT AGAINST IN DOOM?");
        Console.WriteLine("1 - MARCIAL");
        Console.WriteLine("2 - ZOMBIES");
        Console.WriteLine("3 - JEWS");
        Console.WriteLine("4 - DEMONS");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM44()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            DOOM4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    DOOM55();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void DOOM5()
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE DEAD PET OF OUR PROTAGONIST?");
        Console.WriteLine("1 - A CAT");
        Console.WriteLine("2 - A DOG");
        Console.WriteLine("3 - A RABBIT");
        Console.WriteLine("4 - A DUCK");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM55()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            DOOM5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    // HALO
    public static void HaloOptions1()
    {
        Console.Clear();
        Console.WriteLine("WHAT FORM HAVE A HALO?");
        Console.WriteLine("1 - RING FORM");
        Console.WriteLine("2 - SQUARE FORM");
        Console.WriteLine("3 - SPHERE FORM");
        Console.WriteLine("4 - CHAIR FORM");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HaloOptions11()
    { 
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HaloOptions1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    HaloOptions22();
                break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    } 


    public static void HaloOptions2()
    {
        Console.Clear();
        Console.WriteLine("WHO IS THE BEST PLAYER?");
        Console.WriteLine("1 - COCONUT GORILLA");
        Console.WriteLine("2 - CALEX124");
        Console.WriteLine("3 - TARDES_RABBIT");
        Console.WriteLine("4 - LIMAXTIME");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HaloOptions22()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HaloOptions2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    HaloOptions33();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void HaloOptions3()
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE NAME OF THE IA OF HALO 1?");
        Console.WriteLine("1 - CORTANA");
        Console.WriteLine("2 - ALEXA");
        Console.WriteLine("3 - SIRI");
        Console.WriteLine("4 - GOOGLE ASSISTANT");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HaloOptions33()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HaloOptions3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    HaloOptions44();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void HaloOptions4()
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE NAME OF THE ELITE SOLDIERS OF THE HUMANITY?");
        Console.WriteLine("1 - HUNTERS");
        Console.WriteLine("2 - PILOTS");
        Console.WriteLine("3 - ELITES");
        Console.WriteLine("4 - SPARTANS");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HaloOptions44()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HaloOptions4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    HaloOptions55();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void HaloOptions5()
    {
        Console.Clear();
        Console.WriteLine("WHAT OF THIS NAMES IS FROM A RELIGIOUS GROUP");
        Console.WriteLine("1 - FLOOD");
        Console.WriteLine("2 - HUMANITY");
        Console.WriteLine("3 - COVENANT");
        Console.WriteLine("4 - BRUTES");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HaloOptions55()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HaloOptions5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }


    // HOLLOW KNIGHT
    public static void HoloOptions1()
    {
        Console.Clear();
        Console.WriteLine("WHAT'S THE NAME OF THE MAIN PROTAGONIST?");
        Console.WriteLine("1 - THE KNIGHT");
        Console.WriteLine("2 - HOLLOW KNIGHT");
        Console.WriteLine("3 - ZOTE THE MIGHT");
        Console.WriteLine("4 - EDIIIIIIIILEEEE!");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HoloOptions11()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HoloOptions1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    HoloOptions22();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }


    public static void HoloOptions2()
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE FIRST BOSS YOU FIGHT IN THE GAME?");
        Console.WriteLine("1 - MANTIS");
        Console.WriteLine("2 - NIGHTMARE GRIMM");
        Console.WriteLine("3 - BROKEN VESSEL");
        Console.WriteLine("4 - FALSE KNIGHT");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HoloOptions22()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HoloOptions2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    HoloOptions33();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void HoloOptions3()
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE NAME OF THE MONEY IN THE WORLD OF HK?");
        Console.WriteLine("1 - GRAZIA");
        Console.WriteLine("2 - GEO");
        Console.WriteLine("3 - FRISK");
        Console.WriteLine("4 - MONEY, IT'S NAME IS MONEY");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HoloOptions33()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HoloOptions3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    HoloOptions44();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void HoloOptions4()
    {
        Console.Clear();
        Console.WriteLine("WHAT CAN YOU FIND IN THE ABYSS?");
        Console.WriteLine("1 - JUST A GUY THAT GIVES YOU A MAP");
        Console.WriteLine("2 - MAMBA GODS");
        Console.WriteLine("3 - SHADOWS AND DEAD CHILDREN");
        Console.WriteLine("4 - A GNOME");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HoloOptions44()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HoloOptions4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    HoloOptions55();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void HoloOptions5()
    {
        Console.Clear();
        Console.WriteLine("WHO IS THE TRUE VILLAN OF THIS STORY?");
        Console.WriteLine("1 - HOLLOW KNIGHT");
        Console.WriteLine("2 - ZOTE");
        Console.WriteLine("3 - THE RADIANCE");
        Console.WriteLine("4 - SLY");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void HoloOptions55()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            HoloOptions5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("You have failed");
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    Main();
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
}





