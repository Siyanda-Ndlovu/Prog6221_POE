using System;
using System.Threading;

namespace Prog6221_POE
{
    public class welcome_user
    {

        //global variable
        private string username = string.Empty;

        //questins array
        private string[] questions =
        { //start of questions array
            "how are you",
            "purpose",
            "password",
            "phishing",
            "safe browsing",
            "ask"
        };//end of questions array

        //answers array
        private string[] answers =
        { //start of answers array
            "I'm functioning well, thanks for asking",
            "I'm your CyberBuddy, I'm here to help you navigate the digital world safely. " +
            "\nI provide guidance on password safety, phishing prevention and safe browsing",    
            "For password safety tips, you must use a unique password for each account, your password " +
            "\nmust atleast have more than 8 characters, include uppercase, numbers and special characters",
            "Phishing is when scammers trick you into giving personal information. To prevent phishing, " +
            "\nyou must check senders email address carefully.",
            "Always check URLs and avoid suspicious links, look for HTTPS website in URLs. Avoid using public " +
            "\nwi-fi for sensitive transactions, and you must keep your browser updated",
            "You can ask me about password safety, Identifying phishing attempt and Safe browsing",
        }; //end of answers array

        //This is for typing the text instead of WriteLine
        private void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(30); // speed (lower = faster)
            }
            Console.WriteLine();
        }

        //void method to welcome a user
        public void welcome()
        { //start method

            //decorative borders
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("            [ Welcome to CyberBuddy ]     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("           [ Be Protected | Stay Safe ]     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================================");

            //reset the color
            Console.ResetColor();

        }//end method

        public void prompt_user()
        { //start method

            //AI message and name with text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CyberBuddy: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter your name:");
            

            //reset the color
            Console.ResetColor();

            do
            {

                //prompt and text color
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("User: ");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------------------------------------");

            } while (!empty()); //end of do while

        }//end method

        //Boolean method to check the username if not empty
        private Boolean empty()
        {

            //check if not empty by if statement
            if (username != "")
            {

                //success message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CyberBuddy: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeText("Hey " + username + ", Welcome to CyberBuddy!,");
                TypeText("            I'm here to help you stay safe online");
                TypeText("            What would you like to know about today?");
                onsole.ForegroundColor = ConsoleColor.Red;
                TypeText("            Press exit or goodbye to end the program");
                Console.ResetColor();   //reset color
                //return true
                return true;

            }
            else
            { //start of else

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CyberBuddy: ");
                Console.ForegroundColor = ConsoleColor.Red;
                TypeText("Your name field can't be blank!");
                Console.WriteLine("            Please enter your name");
                //return name
                return false;

            } //end of else
        }
        //Method to start chats
        public void startingChat() 
        { //start chat method

            while (true) 
            { //start while loop
                //Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string ans = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------------------------------------");
                Console.ResetColor();

                if (ans.Trim() == "")
                { //start if statement
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter something!");
                    continue;
                } //end if statement

                ans = ans.ToLower();

                //if the user exit the program
                if (ans == "exit" || ans == "goodbye")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("CyberBuddy: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeText("Goodbye " + username + " hope to see you soon");
                    Console.ResetColor();
                    break;
                    
                }

                string response = getAnswer(ans);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CyberBuddy: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeText(response);   //typing effect

                //Reset color
                Console.ResetColor();
            } //end while loop
            
        } //end chat method
        private string getAnswer(string ans)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                if (ans.Contains(questions[i]))
                {
                    return answers[i];
                }
            }

            return getCorrespond(ans);
        }

        private string getCorrespond(string ans)
        {
            if (ans.Contains("hi") || ans.Contains("hello"))
                return "Hello " + username + " How can I help you?";

            if (ans.Contains("thanks") || ans.Contains("thank you"))
                return "You are welcome " + username + ", what else who you like to know?";

            
            return "I didn't understand that question " + username + ", can you please rephrase it";
        }

    }
}
