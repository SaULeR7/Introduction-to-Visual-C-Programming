using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab4
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            int switch_input;
            Write("Chap 4: Programming Exercises: 1, 3 " +
                "\nChap 5: Programming Exercises: 5, 6" +
                "\nChap 6: Programming Exercises: 7, 9" +
                "\nChoose assignment: ");
            if (int.TryParse(ReadLine(), out switch_input))
            {
                switch (switch_input)
                {
                    case 1:
                        {
                            Date();
                            break;
                        }
                    case 3:
                        {
                            Motorway();
                            break;
                        }
                    case 5:
                        {
                            Shipping();
                            break;
                        }
                    case 6:
                        {
                            Area();
                            break;
                        }
                    case 7:
                        {
                            Multiplication_table();
                            break;
                        }
                    case 9:
                        {
                            Triangle();
                            break;
                        }
                    default:
                        {
                            WriteLine("Invalid input");
                            break;
                        }
                }
            }
            else { WriteLine("Invalid input"); }
            
            ReadKey();
        }

        static void Date()
        {
            Write("Input day: ");
            int day = Convert.ToInt32(ReadLine());
            Write("Input month: ");
            int month = Convert.ToInt32(ReadLine());
            Write("Input year: ");
            int year = Convert.ToInt32(ReadLine());

            Date newDate = new Date(month, day, year);
            Write("\nDate you input is ");
            WriteLine(newDate);

            Write("Input month: ");
            string s_month = ReadLine();
            Date newDate1 = new Date(s_month, day, year);
            Write("\nAnother date is ");
            Write(newDate1);
        }

        static void Motorway() {
            Motorway fMotorway = new Motorway();
            fMotorway.NameOfTheHighway = "Jackson";
            fMotorway.TypeOfStreet = "Ave";
            fMotorway.Direction = "N";
            fMotorway.Surface = "Gravel";
            fMotorway.NumberOfLanes = 4;
            fMotorway.IsToll = true;
            fMotorway.Maintains = "State";
            WriteLine("\n\tFirst Motoway\n");
            WriteLine(fMotorway);
            Motorway sMotorway = new Motorway("Jackson", true, "State");
            sMotorway.TypeOfStreet = "Street";
            sMotorway.Direction = "E";
            sMotorway.Surface = "Asphalt";
            sMotorway.NumberOfLanes = 2;
            WriteLine("\n\tSecond Motoway\n");
            WriteLine(sMotorway);
            Motorway tMotorway = new Motorway("Jackson","Blvd","E","Blacktop", 6,false,"Country");
            WriteLine("\n\tThird Motoway\n");
            WriteLine(tMotorway);
        }

        public static void Shipping()
        {
            double standard_price = 2.99, disc_price1 = 1.99, disc_price2 = 1.49, lowest_price = 0.99;
            Write("Enter the # of items: ");
            int items = Convert.ToInt32(ReadLine());

            if (items == 1)
            {
                WriteLine("Your shipping charges are: ${0:.##}", standard_price);
            }
            else if ((items >= 2) && (items <= 5))
            {
                WriteLine("Your shipping charges are: ${0:.##}", (standard_price + (items - 1) * disc_price1));
            }
            else if ((items > 5) && (items < 15))
            {
                WriteLine("Your shipping charges are: ${0:.##}", (standard_price) + (4 * disc_price1) + ((items - 5) * disc_price2));
            }
            else
            {
                WriteLine("Your shipping charges are: ${0:.##}", (standard_price + (4 * disc_price1) + ((10) * disc_price2) + ((items - 14) * lowest_price)));
            }

        }

        public static void Area()
        {
            double radius, length, width, height;
            WriteLine("Please select a figure" +
                "\n1)Circle" +
                "\n2)Rectangle" +
                "\n3)Cylinder");
            int input = Convert.ToInt32(ReadLine());
            if (input == 1) {
                Write("Please input radius: ");
                radius = Convert.ToDouble(ReadLine());
                Figure figure = new Circle(radius);
                WriteLine(string.Format(string.Format("Area = {0:.##}", figure.Area())));
            }
            else if (input == 2) {
                Write("Please input length: ");
                length = Convert.ToDouble(ReadLine());
                Write("Please input width: ");
                width = Convert.ToDouble(ReadLine());
                Figure figure = new Rectangle(length, width);
                WriteLine(string.Format(string.Format("Area = {0:.##}", figure.Area())));
            }
            else {
                Write("Please input radius: ");
                radius = Convert.ToDouble(ReadLine());
                Write("Please input height: ");
                height = Convert.ToDouble(ReadLine());
                Figure figure = new Cylinder(radius, height);
                WriteLine(string.Format(string.Format("Area = {0:.##}", figure.Area())));
            }
        }

        private static void Multiplication_table()
        {
            string inValue, inValue2;
            int first_base, last_base;

            Write("Enter the first base value: ");
            inValue = ReadLine();
            Write("Enter the second base value: ");
            inValue2 = ReadLine();

            if (int.TryParse(inValue, out first_base) && int.TryParse(inValue2, out last_base)
                && (first_base < last_base) && first_base >= 2 && last_base <= 8)
            {
                for (int i = 1; i <= 25; i++)
                {
                    Write(i + "\t");
                    for (int j = first_base; j <= last_base; j++)
                    {
                        if (i > 0) { Write(i * j + "\t"); }
                        else { Write(j + "\t"); }
                    }
                    Write("\n");
                }
            }
            else {
                WriteLine("Invalid input");
            }
        }

        private static void Triangle()
        {
            int size;
            Write("Enter the size of the triangle: ");
            if (!int.TryParse(ReadLine(), out size) || size > 10)
            {size = 3;}

            Write("Enter the character of the triangle: ");
            string character = ReadLine();
            if (character.Length > 1 || Char.IsDigit(character[0]))
            {character = "*";}

            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write(character);
                }
                WriteLine();
            }
            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Write(character);
                }
                WriteLine();
            }
        }
    }
}