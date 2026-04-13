using System;
using System.Threading;

internal class UIHelper
{
    // Typing effect
    public static void TypeText(string text, int speed = 15)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
        Console.WriteLine();
    }

    // Boot sequence
    public static void BootSequence()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        TypeText("Initializing Cyber Prime...");
        Thread.Sleep(400);

        TypeText("Loading security modules...");
        Thread.Sleep(400);

        TypeText("Establishing secure connection...");
        Thread.Sleep(400);

        TypeText("Access Granted.\n");
        Thread.Sleep(300);
    }

    // User theme setup
    public static void SetHackerTheme()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
    }

    // Glowing logo
    public static void ShowLogo()
    {
        string[] logo =
        {
        @" 
   ██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗ ██████╗ ██╗███╗   ███╗███████╗
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔══██╗██║████╗ ████║██╔════╝
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██████╔╝██║██╔████╔██║█████╗
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔═══╝ ██╔══██╗██║██║╚██╔╝██║██╔══╝
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██║     ██║  ██║██║██║ ╚═╝ ██║███████╗
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═╝     ╚═╝  ╚═╝╚═╝╚═╝     ╚═╝╚══════╝
    - Cybersecurity Awareness Chatbot -
"
        };

        ConsoleColor[] glow =
        {
            ConsoleColor.DarkBlue,
            ConsoleColor.Blue,
            ConsoleColor.Cyan,
            ConsoleColor.DarkYellow
        };

        foreach (var color in glow)
        {
            Console.Clear();
            Console.ForegroundColor = color;

            foreach (string line in logo)
                Console.WriteLine(line);

            Thread.Sleep(120);
        }

        Console.ForegroundColor = ConsoleColor.Green;
    }

    // User prompt
    public static void Prompt()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("User: ");
        
    }

    // Chatbot response
    public static void BotMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText("CyberPrime: " + message);
        Console.WriteLine(" ");

    }
    

    // Warning message
    public static void Warning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        TypeText("!! " + message);
        Console.ForegroundColor = ConsoleColor.Green;
    }

    // Info message 
    public static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        TypeText(" " + message);
        Console.ForegroundColor = ConsoleColor.Green;
    }
}