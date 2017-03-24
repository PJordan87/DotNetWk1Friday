using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What color for all rectangles");

            String color = Console.ReadLine();
            Rectangles.color = color;
            color = "invalid color";
            Console.WriteLine("What is the length of the rectangle");
            String length = Console.ReadLine();
            Console.WriteLine("What is the width of the rectangle");
            String width = Console.ReadLine();
            int getlength = Convert.ToInt32(length);
            int getwidth = Convert.ToInt32(width);
            Rectangles rectangle1 = new Rectangles();
            rectangle1.length = getlength;
            rectangle1.width = getwidth;
            rectangle1.findarea();
            int area = rectangle1.findarea();


            Console.WriteLine("What is the length of the rectangle");
            String length2 = Console.ReadLine();
            Console.WriteLine("What is the width of the rectangle");
            String width2 = Console.ReadLine();
            int getlength2 = Convert.ToInt32(length);
            int getwidth2 = Convert.ToInt32(width);
            Rectangles rectangle2 = new Rectangles();
            rectangle2.length = getlength2;
            rectangle2.width = getwidth2;
            int area2 = rectangle2.findarea();
            int totalArea = area + area2;
            Console.WriteLine("Your total area is {0} and the color {1}", totalArea, Rectangles.color);

            Console.ReadKey();

        }

    }
}
