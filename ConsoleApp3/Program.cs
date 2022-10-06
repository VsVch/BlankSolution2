using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();
            double area = 0.0;

            if (fig == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine($"{area:f3}");

            }
            else if (fig == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine($"{area:f3}");
            }
            else if (fig == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine($"{area:f3}");
            }
            else if ( fig=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a*b/2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
