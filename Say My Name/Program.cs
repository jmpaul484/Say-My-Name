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
            Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name}!");
        }
    }
}
