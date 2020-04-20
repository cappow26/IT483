using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2it483
{
    class Program  {
        //Main Method
        static void Main(string[] args) {
            
             //variables for later
            int selectionOfCoatings;
            int selectionOfGlasses;

            //Instantiate the prices of the coatings
            var pricesOfCoatings = new Dictionary<int, decimal>();
            pricesOfCoatings.Add(1, 12.5M);
            pricesOfCoatings.Add(2, 9.99M);

            //Instantiate the prices of the glasses
            var pricesOfGlasses = new Dictionary<int, decimal>();
            pricesOfGlasses.Add(1, 40);
            pricesOfGlasses.Add(2, 25);

            //Ask user for the type of glasses they want, make sure response is valid

            Console.WriteLine("What kind of glasses would you like:");
            do
            {
                Console.Write("1 -> prescription, 2 -> non-prescription : ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out selectionOfGlasses) || !pricesOfGlasses.ContainsKey(selectionOfGlasses));

            //Ask use for type of coating they want, make sure response is valid and display
            Console.WriteLine("What kind of coating would you like:");
            do
            {
                string messageToDisplay = "";

                if (!checkForCoatingRequirement(selectionOfGlasses))
                {
                    messageToDisplay += "0 -> No coating, ";
                }

                Console.Write(messageToDisplay + "1 -> anti-glare, 2 -> brown tint : ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out selectionOfCoatings) || !validityCheckCoatingSelection(selectionOfCoatings, selectionOfGlasses, pricesOfCoatings));

            //Display the final cost of the purchase
            Console.WriteLine($"Your total cost is ${pricesOfGlasses[selectionOfGlasses] + (pricesOfCoatings.ContainsKey(selectionOfCoatings) ? pricesOfCoatings[selectionOfCoatings] : 0)}");

            //end program
            Console.Read();
        }

        //Check the coating requirements, return true of false
        public static bool checkForCoatingRequirement(int typeOfGlasses) {
            int[] glassesRequiringCoating = {1};
            bool check = glassesRequiringCoating.Contains(typeOfGlasses);
            return check;
        }

        //Check for valid coating selection, return true or false
        public static bool validityCheckCoatingSelection(int coatingSelection, int glassesSelection, IDictionary<int, decimal> pricesForCoatings){
            return checkForCoatingRequirement(glassesSelection) ? pricesForCoatings.ContainsKey(coatingSelection) : true;
        }
    }
}