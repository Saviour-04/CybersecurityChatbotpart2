using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot.UI
{
    public static class ConsoleUI
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiArt = @"
╔══════════════════════════════════════════════════════════════════════════════╗
║                                                                              ║
║     ██████╗██╗   ██╗██████╗ ███████╗██████╗                                 ║
║    ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗                                ║
║    ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝                                ║
║    ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗                                ║
║    ╚██████╗   ██║   ██████╔╝███████╗██║  ██║                                ║
║     ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝                                ║
║                                                                              ║
║     █████╗ ██╗    ██╗ █████╗ ██████╗ ███████╗███╗   ██╗███████╗             ║
║    ██╔══██╗██║    ██║██╔══██╗██╔══██╗██╔════╝████╗  ██║██╔════╝             ║
║    ███████║██║ █╗ ██║███████║██████╔╝█████╗  ██╔██╗ ██║███████╗             ║
║    ██╔══██║██║███╗██║██╔══██║██╔══██╗██╔══╝  ██║╚██╗██║╚════██║             ║
║    ██║  ██║╚███╔███╔╝██║  ██║██║  ██║███████╗██║ ╚████║███████║             ║
║    ╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝╚══════╝             ║
║                                                                              ║
║              🔐  CYBERSECURITY AWARENESS BOT  🔐                            ║
║                                                                              ║
║           Your Personal Guide to Online Safety in South Africa              ║
║                                                                              ║
╚══════════════════════════════════════════════════════════════════════════════╝
";
            Console.WriteLine(asciiArt);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void WriteBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("🤖 Bot: ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public static void WriteUserPrompt(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"👤 {userName}: ");
            Console.ResetColor();
        }

        public static void DisplayBorder()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('═', 70));
            Console.ResetColor();
        }

        public static void DisplaySectionHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n📌 {title}");
            DisplayBorder();
            Console.ResetColor();
        }

        public static void DisplayInfoMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nℹ️ {message}");
            Console.ResetColor();
        }

        public static void DisplayTypingEffect(string message, int delayMs = 30)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("🤖 Bot: ");
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void ClearScreen()
        {
            Console.Clear();
            DisplayHeader();
        }

        public static void DisplayGoodbye(string userName)
        {
            DisplayBorder();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n👋 Goodbye, {userName}!");
            Console.WriteLine("   Remember: Stay vigilant, stay secure! 🔐");
            Console.WriteLine("   Thank you for using the Cybersecurity Awareness Bot.\n");
            Console.ResetColor();
            DisplayBorder();
        }
    }
}