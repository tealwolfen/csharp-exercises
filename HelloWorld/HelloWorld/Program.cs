using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double height;
            string input;

            Console.WriteLine("What is the length?");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("Hello " + input);
            Console.ReadLine();
        }
    }
}
