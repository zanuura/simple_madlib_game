// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace MadLibGame
{
    class program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("\n------------------------------\n");
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}