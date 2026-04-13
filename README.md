# CyberBuddy

## Description
CyberBuddy is a console-based chatbot developed in C#. The purpose of this application is to educate users about cybersecurity awareness, including topics such as password safety, phishing, and safe browsing.

The chatbot interacts with users in a friendly and engaging way, using colored text, a typing animation effect, and personalized responses.

---

## Features
-  Voice greeting using a WAV audio file
-  ASCII art welcome screen
-  User name input with validation
-  Interactive chatbot conversation
-  Keyword-based response system
-  Input validation for empty or invalid inputs
-  Colored console interface
-  Typing animation effect (simulates real chatbot responses)
-  Cybersecurity awareness tips

---

## Technologies Used
- C#
- .NET Console Application
- System.Media (for audio playback)

---

## How to Run the Program
1. Open the project in Visual Studio
2. Build the solution
3. Make sure the `greeting.wav` file is in the project directory
4. Run the application
5. Enter your name when prompted
6. Start chatting with CyberBuddy

---

## Example Questions
You can ask CyberBuddy questions like:
- How are you?
- What is your purpose?
- What can I ask you?
- Tell me about password safety
- What is phishing?
- What is safe browsing?

---

## How It Works
The chatbot uses parallel arrays to store questions and responses.  
It checks user input using keyword matching (`Contains`) and returns the most relevant response.

If the input is not recognized, the chatbot provides a fallback message asking the user to rephrase.

---

## Input Validation
- Prevents empty input
- Ensures user enters a valid name
- Handles unknown questions gracefully

---

## Exit Feature
Users can exit the chatbot by typing:
- `exit`
- `goodbye`

The chatbot will respond with a personalized goodbye message.

---

## Author
**Name:** [Siyanda Ndlovu]  
**Course:** Prog6221  
**Project:** Cybersecurity Awareness Chatbot  

---

## Notes
This project demonstrates:
- Basic object-oriented programming (OOP)
- User interaction in console applications
- Input validation techniques
- Simple AI logic using keyword matching

---

## Future Improvements
- Add more advanced AI responses
- Implement natural language processing (NLP)
- Add a graphical user interface (GUI)
- Store chat history
- Expand cybersecurity topics

---

## Stay Safe Online!
CyberBuddy encourages users to practice safe online habits and be aware of cybersecurity threats.
