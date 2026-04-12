using CybersecurityAwarenessBot.Models;
using CybersecurityAwarenessBot.Services;
using CybersecurityAwarenessBot.UI;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ConsoleUI.DisplayHeader();
            AudioPlayer.PlayGreeting("Assets/greeting.wav");

            UserProfile user = new UserProfile();
            ChatbotService chatbot = new ChatbotService();

            ConsoleUI.WriteBotMessage("Hello! Welcome to the Cybersecurity Awareness Bot.");
            ConsoleUI.WriteBotMessage("I am here to help you stay safe online.");
            ConsoleUI.WriteBotMessage("Before we begin, what is your name?");

            user.Name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(user.Name))
            {
                ConsoleUI.WriteBotMessage("You did not enter a name. Please type your name:");
                user.Name = Console.ReadLine();
            }

            ConsoleUI.WriteBotMessage($"Nice to meet you, {user.Name}!");
            ConsoleUI.WriteBotMessage("You can ask me about:");
            ConsoleUI.WriteBotMessage("- password safety");
            ConsoleUI.WriteBotMessage("- phishing");
            ConsoleUI.WriteBotMessage("- safe browsing");
            ConsoleUI.WriteBotMessage("- malware");
            ConsoleUI.WriteBotMessage("- scams");
            ConsoleUI.WriteBotMessage("Type 'exit' to close the chatbot.");

            bool running = true;

            while (running)
            {
                ConsoleUI.WriteUserPrompt(user.Name);
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    ConsoleUI.WriteBotMessage("You entered nothing. Please type a question.");
                    continue;
                }

                string cleanInput = userInput.Trim().ToLower();

                switch (cleanInput)
                {
                    case "exit":
                        ConsoleUI.WriteBotMessage($"Goodbye, {user.Name}. Stay safe online!");
                        running = false;
                        break;

                    default:
                        string response = chatbot.GetResponse(cleanInput, user.Name);
                        ConsoleUI.WriteBotMessage(response);
                        break;
                }
            }
        }
    }
}

