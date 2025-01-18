using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProgramAsignment1
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            Write("Enter maxDegree: ");
            int maxDegrees = Convert.ToInt32(ReadLine());

            for (int i = 0; i <= maxDegrees; i++)
            {
                double sin = mysin(i);
                double cos = mycos(i);
                double tan = mytan(i);
                WriteLine("{0}  {1:N4}  {2:N4}  {3:N4}", i, sin, cos, tan);
            } 
            ReadKey();
        }

        static double mysin(double degrees)
        {
            double radians = convertDegreeToRadians(degrees);
            return Math.Sin(radians);
        }

        static double mycos(double degrees)
        {
            double radians = convertDegreeToRadians(degrees);
            return Math.Cos(radians);
        }

        static double mytan(double degrees)
        {
            double radians = convertDegreeToRadians(degrees);
            return Math.Tan(radians);
        }

        static double convertDegreeToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
    }
}
