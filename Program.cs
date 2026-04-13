namespace Prog6221_POE
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creating an instance voice_greeting class with a constructor
            new voice_greeting() { };

            //creating an instance for the ascii_logo class with a constructor
            new ascii_logo() { };

            //creating an instance with an object name welcoming
            welcome_user welcoming = new welcome_user();

            //calling the method welcome
            welcoming.welcome();

            //calling the method ask_user
            welcoming.prompt_user();

            //calling the startingChat method
            welcoming.startingChat();

            
        }
    }
}
