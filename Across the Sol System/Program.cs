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
            /*
            //String 1;
            //String 2;
            //String 3;
            //String 4;
            //String 5;
            //String 6;
            //String 7;
            //String 8;
            //String 9;
            //This string represents the number denotation of each planet

            double Mercury;
            double Venus;
            double Earth;
            double Mars;
            double Jupiter;
            double Saturn;
            double Uranus;
            double Neptune;
            double Pluto;
            double mercury;
            double venus;
            double earth;
            double mars;
            double jupiter;
            double saturn;
            double uranus;
            double neptune;
            double pluto;
            //This set was made to account for is the user typed the name rather than the number

            Mercury, mercury = 0.37;
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

            int condition = 1;
            do
            {
                int planet;
            Console.WriteLine("\n Which planet are you curious about? Pick one of the numbers!: ");
            planet = Convert.ToInt32(Console.ReadLine());

            double userWeight;
            //Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
            //userWeight = Convert.ToDouble(Console.ReadLine());
            double ratio = 0.0;
            double result;

            /* The previous block of code is */

                switch (planet)
                {
                    case 1:
                        ratio = 0.37;
                        Console.WriteLine("\n How many pounds do you weigh on Earth?: ");
                        userWeight = Convert.ToDouble(Console.ReadLine());
                        result = ratio * userWeight;
                        Console.WriteLine("Let me see... on Mercury you weigh " + result + "lbs");
                        break;

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
                        //Console.WriteLine("Are... are you sure? [Y/N]");
                        //Console
                        condition = ++condition;
                        break;

                    default:
                        Console.WriteLine("Oi! That's not on the list! Try again.");
                        break;
                }
            } while (condition <= 1);

            Console.WriteLine("Good day to you!");


            //Console.ReadLine();

            /* Mercury, mercury = 0.37;
            Venus, venus = 0.88;
            Earth, earth = 1;
            Mars, mars = 0.38;
            Jupiter, jupiter = 2.64;
            Saturn, saturn = 1.15;
            Uranus, uranus = 1.15;
            Neptune, neptune = 1.12;
            Pluto, pluto = 0.04;
            */

            //Write user selection here, move selection on from here to the next step of requesting weight
            //Take weight and selection and input them in the switch statement
            //Nine switch statemts, one for each planet and the default to exi


        }
    }
}
