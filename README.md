# CybersecurityChatbot
# Cybersecurity Awareness Bot - Part 1

**Student:** Saviour Mkhatswa  
**Student Number:** ST10489983  
**Module:** PROG6221 - Programming 2A  
**Year:** 2026

---

## Description

A command-line chatbot that educates users about cybersecurity topics including password safety, phishing, safe browsing, malware, and online scams.

---

## Features

- Voice greeting on startup
- ASCII art logo display
- Asks for and remembers user name
- Answers cybersecurity questions
- Handles invalid inputs
- Colored text for better readability
- Type 'exit' to close

---

## How to Run

1. Open project in Visual Studio
2. Make sure `greeting.wav` is in the `Assets` folder
3. Press `F5` to run

---

## What You Can Ask

| Ask About | Example Question |
|-----------|------------------|
| Password safety | "tell me about passwords" |
| Phishing | "what is phishing" |
| Safe browsing | "safe browsing tips" |
| Malware | "what is malware" |
| Scams | "online scams" |
| Suspicious links | "suspicious links" |

---

## Project Structure

CybersecurityAwarenessBot/
├── Program.cs
├── Models/
│ └── UserProfile.cs
├── Services/
│ ├── ChatbotService.cs
│ ├── ResponseService.cs
│ └── AudioPlayer.cs
├── UI/
│ └── ConsoleUI.cs
└── Assets/
└── greeting.wav

## Sample Conversation
🤖 Bot: Hello! Welcome to the Cybersecurity Awareness Bot.
🤖 Bot: Before we begin, what is your name?

👤 You: Saviour

🤖 Bot: Nice to meet you, Saviour!
🤖 Bot: You can ask me about password safety, phishing, safe browsing, malware, scams

👤 Saviour: tell me about passwords

🤖 Bot: Password safety means creating strong and private passwords that are difficult to guess.

👤 Saviour: exit

🤖 Bot: Goodbye, Saviour. Stay safe online!



---

## GitHub Repository

https://github.com/Saviour-04/CybersecurityChatbot
---

## Video Presentation

[YouTube Link Here]

---

## Commits

6 commits have been made:
1. Initial project setup
2. Added UserProfile and AudioPlayer
3. Added ResponseService
4. Added ChatbotService
5. Added ConsoleUI
6. Completed Program.cs integration

---

**Submitted by:** Saviour Mkhatswa (ST1489983)
