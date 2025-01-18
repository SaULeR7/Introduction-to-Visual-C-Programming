using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter # of exercise(3,5,7): ");
            int a = Convert.ToInt32(ReadLine());
            WriteLine("");

            switch (a)
            {
                case 3:
                    Exercise3();
                    break;
                case 5:
                    Exercise5();
                    break;
                case 7:
                    Exercise7();
                    break;
                default:
                    WriteLine("Wrong input");
                    break;
            }
            ReadKey();
        }

        public static void Exercise3()
        {
            double height, width;
            Write("Input height of a rectangle: ");
            height = Convert.ToDouble(ReadLine());
            Write("Input width of a rectangle: ");
            width = Convert.ToDouble(ReadLine());

            getArea(height, width);
            getPerimeter(height, width);
        }

        public static void getArea(double h, double w) {
            display(h*w);
        }
        public static void getPerimeter(double h, double w) {
            display(-1, (2 * (h + w)));
        }

        public static void display(double area = -1, double perimeter = -1) {
            if (area != -1)
                WriteLine("Area of a rectangle: " + area);
            if (perimeter != -1)
                WriteLine("Perimeter of a rectangle: " + perimeter);
        }
        public static void Exercise5()
        {
            double fahrenheit, celsius;
            Write("Input temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(ReadLine());
            
            celsius = (double)5 / 9 * (fahrenheit - 32);

            WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            WriteLine("Temperature in Celsius: {0:N1}", celsius);
        }
        public static void Exercise7()
        {
            double bill;
            Console.Write("Enter the bill amount: ");
            bill = double.Parse(Console.ReadLine());
            tip(bill);
        }
        public static void tip(double bill)
        {
            double tax, total, tip_15, tip_20;
            tax = bill * 0.09;
            total = bill + tax;
            tip_15 = total * 0.15;
            tip_20 = total * 0.20;
            output(total, total + tip_15, total + tip_20);
        }

        public static void output(double total,double tip15, double tip20)
        {
            WriteLine("Your total prior a tip: {0:N2}", total);
            WriteLine("15% tips: {0:N2}", (tip15 - total));
            WriteLine("20% tips: {0:N2}", (tip20 - total));
            WriteLine("Your total amount after 15% tips: {0:N2}", tip15);
            WriteLine("Your total amount after 20% tips: {0:N2}", tip20);
        }
    }
}