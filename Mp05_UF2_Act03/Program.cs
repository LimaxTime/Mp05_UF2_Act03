internal class Program
{
    public static void ShowOptions()
    {
        Console.Clear();
        Console.WriteLine("WELCOME TO MARC AND JORDI'S QUIZ! NOW CHOOSE A TOPIC:");
        Console.WriteLine("1 - MANGA/ANIME");
        Console.WriteLine("2 - POKEMON");
        Console.WriteLine("3 - INVOICES");
        Console.WriteLine("4 - DOOM");
        Console.WriteLine("5 - HALO");
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
                case ConsoleKey.D4:
                    DOOM1();
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

    public static void DOOM1()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHEN WAS THE FIRST DOOM LAUNCHED TO MARKET?");
        Console.WriteLine("1 - 1995");
        Console.WriteLine("2 - 1998");
        Console.WriteLine("3 - 1993");//CORRECT ANSWER
        Console.WriteLine("4 - 2002");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM11()//OPCIONS DE TECLA
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
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    DOOM22();//CORRECT ANSWER
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

    public static void DOOM2()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("HOW MANY EPISODES DOES DOOM 2 HAVE?");
        Console.WriteLine("1 - 1");
        Console.WriteLine("2 - 2");//CORRECT ANSWER
        Console.WriteLine("3 - 3");
        Console.WriteLine("4 - 4");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM22()//OPCIONS DE TECLA
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
                    break;
                case ConsoleKey.D2:
                    DOOM33();//CORRECT ANSWER
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

    public static void DOOM3()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHICH IS THE MOST POWERFULL WEAPON ON DOOM?");
        Console.WriteLine("1 - BFG");//CORRECT ANSWER
        Console.WriteLine("2 - ROCKER LAUNCHER");
        Console.WriteLine("3 - PISTOL");
        Console.WriteLine("4 - CHAINSAW");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM33()//OPCIONS DE TECLA
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
                    DOOM44();//CORRECT ANSWER
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

    public static void DOOM4()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHAT DO YOU FIGHT AGAINST IN DOOM?");
        Console.WriteLine("1 - MARCIAL");
        Console.WriteLine("2 - ZOMBIES");
        Console.WriteLine("3 - JEWS");
        Console.WriteLine("4 - DEMONS");//CORRECT ANSWER
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM44()//OPCIONS DE TECLA
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
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    DOOM55();//CORRECT ANSWER
                    break;
                default:
                    MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void DOOM5()//OPCIONS VISUALS
    {
        Console.Clear();
        Console.WriteLine("WHAT IS THE DEAD PET OF OUR PROTAGONIST?");
        Console.WriteLine("1 - A CAT");
        Console.WriteLine("2 - A DOG");
        Console.WriteLine("3 - A RABBIT");//CORRECT ANSWER
        Console.WriteLine("4 - A DUCK");
        MsgNextScreen("PRESS A KEY TO RETURN TO THE MAIN MENU");
    }

    public static void DOOM55()//OPCIONS DE TECLA
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
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");
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
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D4:
                    HaloOptions33();
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
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You have failed");
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
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have failed");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("YOU HAVE PASSED THE TEST");
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