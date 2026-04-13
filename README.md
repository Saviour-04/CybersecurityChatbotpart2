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

# CybersecurityChatbot - Setup & Running Guide

## How to Run the Project

### Prerequisites
Before you begin, ensure you have the following installed:

1. **Visual Studio Community** (2019 or later)
   - Download from: https://visualstudio.microsoft.com/downloads/
   - During installation, select ".NET desktop development" workload

2. **.NET Framework** (4.7.2 or later) OR **.NET Core** (3.1 or later)
   - Usually included with Visual Studio installation

3. **Git** (Optional - for version control)
   - Download from: https://git-scm.com/downloads

---

 Run Directly from Visual Studio

### Step 1: Open the Project
1. Launch **Visual Studio Community**
2. Click **File** → **Open** → **Project/Solution**
3. Navigate to your project folder
4. Select the `.csproj` file (e.g., `ChatbotApplication.csproj`)
5. Click **Open**

### Step 2: Build the Project
1. In Visual Studio menu, click **Build** → **Build Solution**
   - Or press `Ctrl + Shift + B`
2. Check the Output window (View → Output) for any errors
3. If build succeeds, you'll see: "Build: 1 succeeded"

### Step 3: Run the Application
1. Click the **Start** button (green triangle) in the toolbar
   - Or press `F5` (with debugging)
   - Or press `Ctrl + F5` (without debugging)
2. A console window will open with the application

---



**Submitted by:** Saviour Mkhatswa (ST1489983)
