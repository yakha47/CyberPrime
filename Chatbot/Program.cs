using System;
using System.Threading;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Console setup
            Console.Title = "Cyber Prime";
            Console.SetWindowSize(100, 40);
          

            // Play greeting in background thread
            Thread audioThread = new Thread(() =>
            {
                AudioService audio = new AudioService();
                audio.PlayGreeting();
            });

            audioThread.IsBackground = true; // ensures it won’t block exit
            audioThread.Start();

            // Small delay so audio starts cleanly
            Thread.Sleep(500);

            // Start chatbot
            ChatBot bot = new ChatBot();
            bot.Start();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + ex.Message);
            Console.ResetColor();
        }
        finally
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}