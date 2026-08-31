//Jonathan_Paul
//RCET_2265
//Fall_2026
//https://github.com/jmpaul484/Say-My-Name.git

namespace Say_My_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is to set the userinput variable to an empty string so that it can be used later in the program.
            string userinput = "";
            //Ask the user for their name and store it in the variable name.
            Console.WriteLine("Hello, What is your name?");
            //Allows the user to input their name
            userinput = Console.ReadLine();
            //Prints out a message to the user with their name.
            Console.WriteLine("Nice to meet you, " + userinput + "! My program is loaded and ready to go. Just press enter to see whats next");
            Console.ReadLine();
            Console.WriteLine("Nevermind " + userinput + ", I don't want to talk to you anymore. Goodbye!");
            ///Pause before the program ends
            Console.ReadLine();
        }
    }
}
