using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            bool keepGoing = true;

            while(keepGoing)
            {
                // Prompt the user to enter an integer
                Console.WriteLine("Guess the right integer! Enter an integer: ");

                string line = Console.ReadLine();

                Int32.TryParse(line, out value);

                if (value >= 10)
                {
                    keepGoing = false;
                    Console.WriteLine("This number is big enough. Press enter twice to exit.");
                }
                else
                {
                    Int32.TryParse(line, out value);

                    if(value <= 10)
                    {
                        Console.WriteLine("The number is too small. Press enter to try again.");
                    }
                    
                }

                Console.ReadLine();
            }
                
        }
    }
}
