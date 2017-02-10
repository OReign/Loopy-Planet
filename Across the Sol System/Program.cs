using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Across_the_Sol_System
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /* For the sake of refrence, here are the constants
             * Mercury, mercury = 0.37;
            Venus, venus = 0.88;
            Earth, earth = 1;
            Mars, mars = 0.38;
            Jupiter, jupiter = 2.64;
            Saturn, saturn = 1.15;
            Uranus, uranus = 1.15;
            Neptune, neptune = 1.12;
            Pluto, pluto = 0.04;
            */


            Console.WriteLine("Hey, listen! I can tell you how much you weigh on other planets!");
            Console.WriteLine("Pick a planet and check it out!");
            Console.WriteLine(" ==================================");
            Console.WriteLine("|Mercury [1] Venus  [2] Mars    [3]|");
            Console.WriteLine("|Jupiter [4] Saturn [5] Uranus  [6]|");
            Console.WriteLine("|Neptune [7] Pluto  [8] No thnx [9]|");
            Console.WriteLine(" ==================================");

            Console.WriteLine();

            /*The above is the simple starting menu that displays the planet option for the user*/

            int condition = 1; //this condition is for the while loop determination, used at the end.
            do
            {
                int planet;
                Console.WriteLine("\n Which planet are you curious about? Pick one of the numbers!");
                Console.WriteLine("Numbers only now! Don't say I didn't warn you!");
                planet = Convert.ToInt32(Console.ReadLine());

                /*This while loop is set to be condition on the int variable contition. The loop itself
             contained a switch statement. The variable 'planet is converted to an integer from the user
             input and used to determine which case to run. If they pick one outside of 1-9, the default runs 
             which sends them back to start of the loop.  I added that extra bit to warn the user as I was unable
             to find a means to limit input to digits only.
                */


                double userWeight;
                double ratio = 0.0;
                double result;

                /* The variables initialized, userWeight for the input values, ratio used in each case for the 
                 * gravity factor and result for the calculated weight */

                switch (planet)
                //This is the start of the switch statement containing the 8 planets and exit statement
                {
                    case 1:
                        ratio = 0.37;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Mercury you weigh " + result + "lbs");
                        break;
                    /*this structure continues through the block, requesting the weight, converting it to 
                    a double, using the new decimal to calculate the weight with the ratio variable.
                    Once that is done, the program outputs a code the weight (result) to the user*/

                    case 2:
                        ratio = 0.88;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Venus you weigh " + result + "lbs");
                        break;

                    case 3:
                        ratio = 0.38;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Mars you weigh " + result + "lbs");
                        break;

                    case 4:
                        ratio = 2.64;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Jupiter you weigh " + result + "lbs");
                        break;

                    case 5:
                        ratio = 1.15;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Saturn you weigh " + result + "lbs");
                        break;

                    case 6:
                        ratio = 1.15;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Uranus you weigh " + result + "lbs");
                        break;

                    case 7:
                        ratio = 1.12;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Neptune you weigh " + result + "lbs");
                        break;

                    case 8:
                        ratio = 0.04;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Pluto you weigh " + result + "lbs");
                        break;

                    case 9:
                        Console.WriteLine("No thanks? No thanks? Mean... see if I ever help you with anything...");
                        Console.WriteLine("Are... are you sure? [Y/N]");
                        if (Console.ReadLine() == "Y")
                        {
                            condition = ++condition;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Huzzah! Let's keep going!");
                            break; }
                        /*My exit statement is two staged. Selecting case 9 bring up the choice to exit,
                         with an if loop in place in case they entered it by mistake, giving them the option
                         to continue the while loop without ending it. If they select Y, the contidition variable
                         set up earlier is increased by 1, thereby ending the while loop.*/

                    default:
                        Console.WriteLine("Oi! That's not on the list! Try again.");
                        break;
                        /* A simple default that is triggered if they enter a value outside of 1-9 */
                }
            } while (condition <= 1);
            /* As mentioned, the do while loop continues only if the condition variable is 1 or lower. 
             Case 9 has the means of ending the loop*/

            Console.WriteLine("Good day to you!");
            Console.ReadLine();
            //A simple goodbye

        }
    }
}
