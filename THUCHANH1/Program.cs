using System;
using System.Text;
namespace THUCHANH1
{
    class DateDifference
    {
        /// defining Number of days in month; index 0=> january and 11=> December
        /// february contain either 28 or 29 days, that's why here value is -1
        /// which wil be calculate later.
        private int[] monthDay = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// contain from date
        private DateTime fromDate;

        /// contain To Date
        private DateTime toDate;

        /// this three variable for output representation..
        private int year;
        private int month;
        private int day;

        public DateDifference(DateTime d1, DateTime d2)
        {
            int increment;
            if (d1 > d2)
            {
                this.fromDate = d2;
                this.toDate = d1;
            }
            else
            {
                this.fromDate = d1;
                this.toDate = d2;
            }

            /// Day Calculation
            increment = 0;
            if (this.fromDate.Day > this.toDate.Day)
                increment = this.monthDay[this.fromDate.Month - 1];
            /// if it is february month
            /// if it's to day is less then from day
            if (increment == -1)
            {
                if (DateTime.IsLeapYear(this.fromDate.Year))
                {
                    // leap year february contain 29 days
                    increment = 29;
                }
                else
                {
                    increment = 28;
                }
            }
            if (increment != 0)
            {
                day = (this.toDate.Day + increment) - this.fromDate.Day;
                increment = 1;
            }
            else
            {
                day = this.toDate.Day - this.fromDate.Day;
            }

            /// month calculation
            if ((this.fromDate.Month + increment) > this.toDate.Month)
            {
                this.month = (this.toDate.Month + 12) - (this.fromDate.Month + increment);
                increment = 1;
            }
            else
            {
                this.month = (this.toDate.Month) - (this.fromDate.Month + increment);
                increment = 0;
            }


            /// year calculation
            this.year = this.toDate.Year - (this.fromDate.Year + increment);

        }
        public override string ToString()
        {
            //return base.ToString();
            return this.year + " Year(s), " + this.month + " month(s), " + this.day + " day(s)";
        }

        public int Years
        {
            get
            {
                return this.year;
            }
        }

        public int Months
        {
            get
            {
                return this.month;
            }
        }

        public int Days
        {
            get
            {
                return this.day;
            }
        }

    }
    class Program
    {

        public static void Main(string[] args)
        {
            DateTime date_1 = DateTime.Parse(Console.ReadLine());
            DateTime date_2 = DateTime.Parse(Console.ReadLine());
            DateDifference date_diff = new DateDifference(date_1, date_2);
            Console.WriteLine(date_diff);
        }
    }
}