﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = (Console.ReadLine());

            switch (name)

            {
                case "dog":
                    {
                        Console.WriteLine("mammal");
                        break;
                    }

                case "snake":

                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                case "crocodile":

                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                case "tortoise":

                    {
                        Console.WriteLine("reptile");
                        break;
                    }





                default:
                    {
                        Console.WriteLine("unknown");
                    }

                    break;


            }





        }
    }
}
