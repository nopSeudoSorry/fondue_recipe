using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_fondue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cheeseBase = 800;
            double waterBase = 2.0;
            double garlicBase = 2.0;
            int breadBase = 400;

            int quantityCheeseBase = cheeseBase / 4;
            double quantityWaterBase = waterBase / 4;
            double quantityGarlicBase = garlicBase / 4;
            int quantityBreadBase = breadBase / 4;

            Console.WriteLine("Enter the number of people invited to the fondue  : ");
            string nbc;
            int nbGuests;
            nbc = Console.ReadLine();
            nbGuests = Convert.ToInt32(nbc);

            int newCheeseQuantity = quantityCheeseBase * nbGuests;
            double newWaterQuantity = quantityWaterBase * nbGuests;
            double newGarlicQuantity = quantityGarlicBase * nbGuests;
            int newBreadQuantity = quantityBreadBase * nbGuests;

            Console.WriteLine("To make a Fondue Fribourgeoise for " + nbGuests + " people, you need : ");
            Console.WriteLine("- " + newCheeseQuantity + " grams of Vacherin Fribourgeois");
            Console.WriteLine("- " + newWaterQuantity + " deciliter of water");
            Console.WriteLine("- " + newGarlicQuantity + " garlic clove");
            Console.WriteLine("- " + newBreadQuantity + " grams of bread");
            Console.WriteLine("- " + "pepper as desired");
            Console.WriteLine("- To drink with it choose preferably one (or several) bottle(s) of white wine !");

            Console.ReadLine();
        }
    }
}
