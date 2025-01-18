using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter # of exercise(1,2,4,6,10): ");
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
                case 6:
                    Exercise6();
                    break;
                case 10:
                    Exercise10();
                    break;
                default:
                    WriteLine("Wrong input");
                    break;
            }
            ReadKey();
        }

        public static void Exercise1()
        {
            double fahrenheit, celsius;
            Write("Input temperature in Celsius: ");
            celsius = Convert.ToDouble(ReadLine());

            fahrenheit = (double)9 / 5 * celsius + 32;

            celsius = (double)5 / 9 * (fahrenheit - 32);

            WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            WriteLine("Converted back temperature in Celsius: " + celsius);

        }
        public static void Exercise2()
        {
            double mile, feet, kilometer;
            Write("Input distance in MILES: ");
            mile = Convert.ToDouble(ReadLine());
            feet = mile * 5280;
            kilometer = 1.609 * mile;

            WriteLine("Distance in foot: " + feet);
            WriteLine("Distance in kilometers: " + kilometer);
        }
        public static void Exercise4()
        {
            int Cents, quarters, dimes, nickels, pennies;
            Write("Input number of cents: ");
            Cents = Convert.ToInt32(ReadLine());
            quarters = Cents / 25;
            Cents %= 25;
            dimes = Cents / 10;
            Cents %= 10;
            nickels = Cents / 5;
            pennies = Cents % 5;

            WriteLine("Quarters : " + quarters + "\nDimes : " + dimes 
                + "\nNickels : " + nickels + "\nPennies : " + pennies);
        }
        public static void Exercise6()
        {
            string employeeName = "Joshua Montain";
            double total_sales/* = 161432*/, total_commission,
                federal_tax, retirement_program, social_security, take_home;
            
            Write("Input total sales: ");
            total_sales = Convert.ToDouble(ReadLine());

            total_commission = total_sales * 0.07;
            federal_tax = total_commission * 0.18;
            retirement_program = total_commission * 0.1;
            social_security = total_commission * 0.06;
            take_home = total_commission - federal_tax - retirement_program - social_security;

            
            WriteLine("Employee Name : " + employeeName + "\nTotal Sales : " + total_sales
                + "\nTotal Commission : " + total_commission + "\nFederal Tax : " + federal_tax + 
                "\nRetirement Program : " + retirement_program + "\nSocial Security : " + social_security + 
                "\nTake Home Pay : " + take_home);
        }
        public static void Exercise10()
        {
            const double pound_to_gram = 4.53;
            double  cost_gram;
            
            Write("Input price per 100 grams : ");
            cost_gram = Convert.ToDouble(ReadLine());

            WriteLine(" $" + cost_gram + " per 100 gram" + "\n $"
                + (pound_to_gram * cost_gram) + " per 1 pound");
        }
    }
}
