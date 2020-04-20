using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
             * My response to the questions asked in the instructions
             * 
             * 2. They are equal, however the first was is more verbose, but ultimately you will get the same result.
             * 
             * 5. None of them need to be written in block form, ultimately you could just right reach if statement after the next without blocks.
             *     There are four possible be scenarios, so therefore 4 IF statements.
 */


namespace lab1it483
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CS 201 Restaurant Guide\n");

            string Response;
            char s, f;
            bool spicy, fancy;

            // Ask user for his/her preference
            Console.Write("Do you like spicy food? (y / n) : ");
            // Get the next token
            Response = Console.ReadLine();
            // Look only at first character
            s = Response[0];
            if (s.Equals('y') || s.Equals('Y'))
            {
                spicy = true;
            }
            else
            {
                spicy = false;
            }

            // Ask user for his/her preference
            Console.Write("Do you want to go to a fancy restaurant? (y / n) : ");
            // Get the next token
            Response = Console.ReadLine();
            // Look only at first character
            f = Response[0];
            fancy = f.Equals('y') || f.Equals('Y');

            // Make suggestion
            if (spicy && fancy)
            {
                Console.WriteLine("I suggest you go to Thai Garden Palace.");
            }
            else
            {
                if (!spicy && !fancy)
                {
                    Console.WriteLine("I suggest you go to Joe's Diner.");
                }
                else
                {
                    if (spicy && !fancy)
                    {
                        Console.WriteLine("I suggest you go to Alberto's Tacqueria.");
                    }
                    else
                    {
                        if (!spicy && fancy)
                        {
                            Console.WriteLine("I suggest you go to Chez Paris.");
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}