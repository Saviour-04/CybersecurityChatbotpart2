# 📘 README – Part 2: Cybersecurity Awareness Chatbot (GUI)

## Project Information

- **Module:** Programming 2A (PROG6221)  
- **Assessment:** POE Part 2  
- **Student Name:** Saviour Mkhatshwa  
- **Student Number:** ST10489983  
- **Year:** 2026  

---

## Overview

This is Part 2 of the Cybersecurity Awareness Chatbot project. The application has been upgraded from a command‑line tool to a **Graphical User Interface (GUI)** using **Windows Forms (WinForms)**.  

The chatbot educates South African citizens about online safety, including topics such as password safety, phishing, and safe browsing. Part 2 introduces:

- A clean, user‑friendly GUI  
- Keyword recognition for cybersecurity topics  
- Randomised responses for engaging conversations  
- Conversation flow (follow‑up handling)  
- Memory to recall user details (name, interests)  
- Sentiment detection (worried, curious, frustrated)  
- Robust error handling  
- Optimised code structure using collections and OOP  

All Part 1 features (voice greeting, ASCII art, personalised messages) are now fully integrated into the GUI.

---

## Features Implemented

### 1. GUI Design and Implementation
- Windows Forms application with input area, output display, and buttons.  
- Colours, spacing, and layout designed for clarity.  
- ASCII art displayed as a header label.  
- Voice greeting plays on application start.

### 2. Keyword Recognition
Recognises at least three cybersecurity keywords:
- `password` → provides password safety tips  
- `scam` / `phishing` → provides scam / phishing guidance  
- `privacy` → gives advice on protecting personal information  

### 3. Random Responses
For topics like phishing tips, the chatbot randomly selects one of several predefined responses, making conversations feel natural and varied.

### 4. Conversation Flow
The chatbot maintains context across multiple messages:
- Follow‑up phrases like *“tell me more”*, *“another tip”*, or *“explain more”* continue the current topic.  
- No need to retype keywords repeatedly.

### 5. Memory and Recall
- Remembers the user’s name and favourite cybersecurity topic.  
- Uses stored information later to personalise responses (e.g., *“As someone interested in privacy, you might want to review your account settings.”*)

### 6. Sentiment Detection
Detects simple sentiments in user input:
- `worried`, `scared`, `nervous` → empathetic, reassuring responses  
- `curious`, `interested`, `tell me` → enthusiastic, detailed answers  
- `frustrated`, `annoying`, `confusing` → apologetic and helpful tone  

The chatbot adapts its response without requiring the user to repeat the original question.

### 7. Error Handling and Edge Cases
- Default response for unrecognised input: *“I’m not sure I understand. Can you try rephrasing?”*  
- No crashes on empty input, invalid keywords, or unexpected phrases.  
- Professional, stable behaviour.

### 8. Code Optimisation and OOP
- Uses `Dictionary<string, List<string>>` for keyword‑response mapping.  
- Random response selection with `Random` class.  
- Separate classes (`ChatbotGUI`, `ChatbotLogic`, `SentimentAnalyzer`, `MemoryManager`) for clean, maintainable code.  
- Ready for further expansion in Part 3.

---

## Prerequisites

- **Windows OS** (for `System.Media` and Windows Forms)  
- **.NET 6.0 SDK** or higher  
- **Visual Studio 2022** (or any edition with WinForms designer)  
- **Git** (for cloning and version control)

---

## Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/ST10489983/Cybersecurity-Chatbot-POE.git
cd Cybersecurity-Chatbot-POE
```

### 2. Open in Visual Studio
- Double‑click the solution file (`.sln`) or  
- Open Visual Studio → **File** → **Open** → **Project/Solution** and select the `.sln` file.

### 3. Restore NuGet Packages (if any)
- Right‑click the solution → **Restore NuGet Packages**  
- (No external packages are required for basic WinForms, but `System.Windows.Extensions` may be needed for `SoundPlayer`.)

### 4. Build the Project
- Press `Ctrl + Shift + B` or  
- Click **Build** → **Build Solution**

### 5. Run the Application
- Press `F5` to run with debugging, or `Ctrl + F5` without debugging.

---

## How to Use the GUI

When you launch the application:

1. A voice greeting plays automatically.  
2. The main window appears with:
   - An ASCII art logo at the top  
   - A **text input box** for your messages  
   - A **Send** button (or press Enter)  
   - A **scrollable chat history** area displaying the conversation  

### Example Interactions

| You type | Chatbot response |
|----------|------------------|
| `Hello` | “Hi [your name]! Welcome back. How can I help you stay safe online today?” |
| `Tell me about passwords` | (Random response about strong passwords, uniqueness, password managers) |
| `I'm worried about online scams` | “It's completely understandable to feel that way. Scammers can be very convincing. Let me share some tips to help you stay safe…” (then provides a tip) |
| `Give me another tip` | (Continues the same topic – e.g., another phishing tip) |
| `I'm interested in privacy` | “Great! I'll remember that you're interested in privacy. It's a crucial part of staying safe online.” |
| (Later) `What can you tell me?` | “As someone interested in privacy, you might want to review the security settings on your accounts.” |
| `exit` or `goodbye` | Closes the application politely. |

### Sentiment Examples

- *“I'm scared of identity theft”* → Reassuring + practical steps.  
- *“This is confusing”* → Apologetic + simpler explanation.  
- *“Tell me something cool about cybersecurity”* → Enthusiastic fun fact.

---

## Project Structure (Part 2)
Solution 'WinFormsApp1' (1 of 1)
└── Cybersecurity Awareness
    ├── Dependencies
    ├── Assets
    │   └── greeting.wav
    ├── Models
    │   └── UserProfile.cs
    ├── Services
    │   ├── Audioplayer.cs
    │   ├── ChatbotService.cs
    │   ├── MemoryServices.cs
    │   ├── RespondService.cs
    │   └── SentimentService.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    └── Program.cs


---

## GitHub & Version Control

This repository follows the required guidelines:

- **Minimum 6 commits** with meaningful messages.  
- **GitHub Actions** CI workflow configured (builds on every push).  
- **Two releases** (minimum for Part 2):
  - `v1.0.0` – Part 1 (console application)  
  - `v2.0.0` – Part 2 (GUI with all new features)  

### Releases

| Tag | Description |
|-----|-------------|
| `v1.0.0` | Command‑line chatbot (Part 1) – voice, ASCII, basic responses |
| `v2.0.0` | GUI version with keyword recognition, memory, sentiment, random responses |

---

## Continuous Integration (CI)

GitHub Actions automatically builds the project on every push to `main` or `master`.  
The workflow:
- Checks out the code  
- Sets up .NET 6.0  
- Restores dependencies  
- Builds in Release configuration  


---

## Video Presentation (Part 2)

An **unlisted YouTube video** has been submitted alongside this code. The video includes:

- A complete demonstration of all GUI features  
- Voice‑over explanation of the code structure, logic, and techniques  
- Walkthrough of keyword recognition, random responses, conversation flow, memory, and sentiment detection  
- Overview of error handling and code optimisation  

📹 **YouTube Link:** [Insert your unlisted YouTube URL here]

---



---

## Troubleshooting

| Problem | Solution |
|---------|----------|
| Voice greeting doesn't play | Ensure `greeting.wav` is in the `Audio` folder and its **Copy to Output Directory** property is set to `Copy if newer`. |
| ASCII art doesn't appear | Check that `logo.txt` exists in the `ASCII` folder and is copied to the output directory. |
| GUI doesn’t build | Make sure you have .NET 6.0 SDK installed and that the project targets `net6.0-windows` (for WinForms). |
| Random responses are always the same | This may happen if you create a new `Random` instance too quickly. The code uses a shared static instance to avoid this. |
| Sentiment not detected correctly | Sentiment detection relies on specific keywords. Expand the keyword lists if needed. |

---

## References

Pieterse, H. 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review. *The African Journal of Information and Communication*, 28(28). doi: https://doi.org/10.23962/10539/32213

---

## Declaration

I, **Saviour Mkhatshwa** (ST10489983), hereby declare that this is my own original work. All sources used have been appropriately acknowledged. This submission follows The IIE’s intellectual integrity and plagiarism policies.

---


---


**GitHub Repository:**https://github.com/Saviour-04/CybersecurityChatbotpart2/edit/master/README.md
