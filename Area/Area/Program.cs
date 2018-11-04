using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double area;

            Console.WriteLine("Enter radius:");
            input = Console.ReadLine();
            double radius = double.Parse(input);

            area = 3.14 * radius * radius;

            Console.WriteLine("The area of a circle with radius "
                + "is: " + area);
            Console.ReadLine();

        }
    }
}
