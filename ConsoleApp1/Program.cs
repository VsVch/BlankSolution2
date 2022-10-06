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
            string pas = Console.ReadLine();

            if ( pas == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
                Console.WriteLine("Wrong password!");

        }
    }
}
