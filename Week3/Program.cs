using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool debug = false;

            Console.WriteLine("Enter your height in cm");
            int height = Convert.ToInt32(Console.ReadLine());

            // .25 is height of coins , .2 amount of coing value
            float total = (height / 0.25f) * 0.2f;

            if (total == 150)
            {
                Console.WriteLine("your height in 20x coins in the same as $150");
            }
            else if (total > 150)
            {
                Console.WriteLine("your height is " + total + " thats more than 150$!");
            }
            else
            {
                Console.WriteLine("wowa your short! your height is " + total + " .. take the money!");
            }
           
            // not sure how i should debug is there a common way to ?
            if (debug == true)
            {
                Console.WriteLine("height = " + height );
            }
            
            Console.ReadLine();

        }
    }
}
