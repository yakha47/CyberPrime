using System;

internal class ChatBot
{
    private ResponseHandler responder = new ResponseHandler();
    private string userName = string.Empty;

    public void Start()
    {
        Console.Title = "Cyber Prime Terminal";

        // Apply hacker theme
        UIHelper.SetHackerTheme();

        // Show glowing logo
        UIHelper.ShowLogo();

        // Boot sequence animation
        UIHelper.BootSequence();

        // Get user name with validation
        GetUserName();

        // Welcome message with user's name
        UIHelper.Info($"**********************************");
        UIHelper.Info($"Welcome, {userName}!");
        UIHelper.Info("Hello! Cyber Prime at your service");
        UIHelper.Info("Ask me about online safety.\n");
        UIHelper.Info("**********************************");
        UIHelper.Info("Type 'help' for commands");
        UIHelper.Info("Type 'exit' to disconnect");
        UIHelper.Info("**********************************\n");

        // Main chatbot loop
        while (true)
        {
            UIHelper.Prompt();
            string? input = Console.ReadLine();

            // Handle null input
            if (input == null)
            {
                continue;
            }

            string normalizedInput = input.ToLower().Trim();

            // Exit command
            if (normalizedInput == "exit")
            {
                UIHelper.Warning($"Goodbye, {userName}! Disconnecting from Cyber Prime...");
                break;
            }

            // Help command 
            if (normalizedInput == "help")
            {
                UIHelper.Info("Available topics:");
                UIHelper.Info("- passwords");
                UIHelper.Info("- phishing");
                UIHelper.Info("- malware");
                UIHelper.Info("- privacy");
                UIHelper.Info("- wifi");
             
                continue;
            }

            // Get response from handler
            string response = responder.GetResponse(normalizedInput);

            // Smart warning detection 
            if (response.ToLower().Contains("warning"))
            {
                UIHelper.Warning(response);
            }
            else
            {
                UIHelper.BotMessage(response);
            }
        }
    }

    private void GetUserName()
    {
        UIHelper.Info("**************************************");
        UIHelper.Info("Welcome to Cyber Prime Security System");
        UIHelper.Info("**************************************\n");

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter your name: ");
            Console.ResetColor();

            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                userName = input.Trim();

                // Optional: Capitalize first letter of each name part
                string[] nameParts = userName.Split(' ');
                for (int i = 0; i < nameParts.Length; i++)
                {
                    if (nameParts[i].Length > 0)
                    {
                        char[] letters = nameParts[i].ToCharArray();
                        letters[0] = char.ToUpper(letters[0]);
                        nameParts[i] = new string(letters);
                    }
                }
                userName = string.Join(" ", nameParts);
            }
            else
            {
                UIHelper.Warning("Invalid name. Please enter a valid name.");
            }
        }

        UIHelper.Info($"\nSetting up security profile for {userName}...");
        System.Threading.Thread.Sleep(800);
        UIHelper.Info("Profile ready!\n");
        System.Threading.Thread.Sleep(500);
    }
}