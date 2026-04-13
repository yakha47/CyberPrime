using System.Media;

public class AudioService
{
    public void PlayGreeting()
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "Voice Greeting.wav");

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.Play(); // Play Audio
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Voice greeting file not found - continuing without audio]");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Audio error: " + ex.Message + "]");
            Console.ResetColor();
        }
    }
} 