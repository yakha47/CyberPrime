using System;

internal class ResponseHandler
{
    private Random rand = new Random();

    public string GetResponse(string input)
    {
        // Passwords
        if (input.Contains("password"))
            return RandomChoice(new string[]
            {
                "Use strong passwords with uppercase, lowercase, numbers, and symbols.",
                "Avoid using names or birthdays in passwords.",
                "Use a password manager to store complex passwords safely."
            });

        // Phishing
        else if (input.Contains("phishing"))
            return RandomChoice(new string[]
            {
                "Phishing scams try to trick you into giving personal information.",
                "Always check the sender’s email before clicking links.",
                "WARNING: Suspicious links can steal your data."
            });

        // Malware / Viruses
        else if (input.Contains("virus") || input.Contains("malware"))
            return RandomChoice(new string[]
            {
                "Install trusted antivirus software and keep it updated.",
                "Avoid downloading files from unknown websites.",
                "WARNING: Malware detected systems can compromise your data."
            });

        // WIFI
        else if (input.Contains("wifi") || input.Contains("public wifi"))
            return RandomChoice(new string[]
            {
                "Avoid logging into sensitive accounts on public Wi-Fi.",
                "Use a VPN when connected to public networks.",
                "Public Wi-Fi can be unsafe without encryption."
            });

        // Privacy
        else if (input.Contains("privacy"))
            return RandomChoice(new string[]
            {
                "Always review privacy settings on social media.",
                "Limit the personal information you share online.",
                "Think before you post — once online, always online."
            });

        // Fake Hacking Commands
        else if (input == "scan")
            return "Scanning system... No threats detected.";

        else if (input == "firewall")
            return "Firewall status: ACTIVE and protecting your system.";

        else if (input == "encrypt")
            return "Encrypting data... All files secured.";

        // Help
        else if (input.Contains("help"))
            return "Commands: passwords, phishing, malware, wifi, privacy, vpn, 2FA, scan, firewall, encrypt.";

        // Default
        else
            return RandomChoice(new string[]
            {
                "I didn't understand that. Try a cybersecurity topic.",
                "Command not recognized. Type 'help' for options.",
                "Unknown input detected. Please try again."
            });
    }

    // Random response selector
    private string RandomChoice(string[] options)
    {
        return options[rand.Next(options.Length)];
    }
}