using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Date
    {
        private int year;
        public int Year {
            get { return year; }
            set { year = value; }
        }
        
        private int month;
        public int Month {
            get { return month; }
            set { month = value; }
        }

        private int day;
        public int Day {
            get { return day; }
            set { day = value; }
        }
        
        private string month_string;
        public string Month_string {
            get { return month_string; }
            set { month_string = value; }
        }
        
        public Date() { }
        public Date(int _month, int _day, int _year)
        {
            this.year = _year;
            this.month = _month;
            this.day = _day;
            this.month_string = getNameOfMonth();
        }
        public Date(string _month, int _day, int _year)
        {
            this.year = _year;
            this.month_string = _month;
            this.day = _day;
            this.month = DateTime.ParseExact(_month, "MMMM", CultureInfo.CurrentCulture).Month;
        }

        public override string ToString()
        {
            return month + "/" + day + "/" + year + " or " + getNameOfMonth() + " " + day + ", " + year;
        }

        public string getNameOfMonth()
        {
            string mName = new DateTime(year, month, day).ToString("MMMM");
            return mName;
        }
    }
}
