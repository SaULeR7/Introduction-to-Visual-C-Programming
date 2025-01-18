using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter # of exercise(1,2,4,5,6,9): ");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("");

            switch (a)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                case 4:
                    Exercise4();
                    break;
                case 5:
                    Exercise5();
                    break;
                case 6:
                    Exercise6();
                    break;
                case 9:
                    Exercise9();
                    break;
                default:
                    WriteLine("Wrong input");
                    break;
            }
            ReadKey();
        }

        public static void Exercise1()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            WriteLine("Hello World! My name is Ivan Chukharev!");
        }
        public static void Exercise2()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;

            WriteLine("****************************************************");
            WriteLine("**\tProgramming Assignment #1                 **");
            WriteLine("**\tDeveloper: Ivan Chukharev                 **");
            WriteLine("**\tDate Submitted: September 25              **");
            WriteLine("**\tPurpose: Provide Internal documentation.  **");
            WriteLine("****************************************************");
        }
        public static void Exercise4()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            WriteLine("                                        ");
            WriteLine(" ccccccccccc                            ");
            WriteLine(" cc                     ##   ##         ");
            WriteLine(" cc                  ##############     ");
            WriteLine(" cc                     ##   ##         ");
            WriteLine(" cc                  ##############     ");
            WriteLine(" cc                     ##   ##         ");
            WriteLine(" ccccccccccc                            ");
            WriteLine("                                        ");
        }
        public static void Exercise5()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            WriteLine("                                       ");
            WriteLine(" *******_____________________________  ");
            WriteLine(" *******_____________________________  ");
            WriteLine(" *******_____________________________  ");
            WriteLine(" *******_____________________________  ");
            WriteLine(" ____________________________________  ");
            WriteLine(" ____________________________________  ");
            WriteLine("                                       ");

        }
        public static void Exercise6()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            WriteLine(" Output #1\n\tLaugh often, Dream big, Reach for the stars!");
            WriteLine(" Output #2\n\tLaugh often, \n\tDream big, \n\tReach for the stars!");
            WriteLine(" Output #3\n\tLaugh \n\toften, \n\tDream \n\tbig, \n\tReach \n\tfor \n\tthe \n\tstars!");
        }

        public static void Exercise9()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;

            WriteLine("                                                                                  ");
            WriteLine("  * * * * * * * * *                      *                             *          ");
            WriteLine("  * * * * * * * * *                    * * *                         * * *        ");
            WriteLine("  * * * * * * * * *                  * * * * *                     * * * * *      ");
            WriteLine("  * * * * * * * * *                * * * * * * *                 * * * * * * *    ");
            WriteLine("  * * * * * * * * *              * * * * * * * * *             * * * * * * * * *  ");
            WriteLine("  * * * * * * * * *            * * * * * * * * * * *             * * * * * * *    ");
            WriteLine("  * * * * * * * * *          * * * * * * * * * * * * *             * * * * *      ");
            WriteLine("  * * * * * * * * *        * * * * * * * * * * * * * * *             * * *        ");
            WriteLine("  * * * * * * * * *      * * * * * * * * * * * * * * * * *             *          ");
            WriteLine("                                                                                  ");
        }
    }
}
