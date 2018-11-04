using System;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height:");
            string heightInput = Console.ReadLine();

            Console.WriteLine("Enter width:");
            string widthInput = Console.ReadLine();

            int perimeter = CalculatePerimeter(heightInput, widthInput);

            Console.WriteLine(perimeter);
            Console.ReadLine();
        }

        private static int CalculatePerimeter(string heightInput, string widthInput)
        {
            int perimeter = 0;
            int height = int.Parse(heightInput);
            int width = int.Parse(widthInput);
            perimeter = 2 * height + 2 * width;
            return perimeter;
      
        }
    }
}
