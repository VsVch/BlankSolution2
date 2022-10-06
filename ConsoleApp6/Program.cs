using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceVacation = double.Parse(Console.ReadLine());
            double countFirstToy = double.Parse(Console.ReadLine());
            double countSecondToy = double.Parse(Console.ReadLine());
            double countThreetoy = double.Parse(Console.ReadLine());
            double countFourtoy = double.Parse(Console.ReadLine());
            double countFiveToy = double.Parse(Console.ReadLine());

            double prodajbi = countFirstToy * 2.6 + 3 * countSecondToy + 4.1 * countThreetoy + 8.2 * countFourtoy + 2 * countFiveToy;
            double toys = countFirstToy+countSecondToy +  countThreetoy +  countFourtoy +  countFiveToy;
            
          

            if (toys >= 50)
            {
                
                double profit = prodajbi * .75;
                profit = profit - profit * .1;


                if (profit > priceVacation)
                {
                    Console.WriteLine($"Yes! {profit - priceVacation:f2} lv left.");
                }

                else
                {
                    Console.WriteLine($"Not enough money! {priceVacation - profit:f2} lv needed.");
                }



            }

            else
            {
                double profit = prodajbi ;
                profit = profit - profit * .1;

                if (profit >= priceVacation)
                {
                    Console.WriteLine($"Yes! {profit - priceVacation:f2} lv left.");
                }

                else
                {
                    Console.WriteLine($"Not enough money! {priceVacation - profit:f2} lv needed.");
                }





            }



           
        }
    }
}
