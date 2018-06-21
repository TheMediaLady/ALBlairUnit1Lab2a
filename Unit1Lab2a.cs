using System;

namespace GCLab1Part2
/* Created by Aquoinette L. Blair
  Grand Rapids, MI
 */ 
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime arrival;
            DateTime day;
            DateTime today = DateTime.Now;
          
            Console.WriteLine("Enter your first day in mm/dd/yyyy format");
            arrival = Convert.ToDateTime(Console.ReadLine()).Date;

            Console.WriteLine("Enter your second day in mm/dd/yyyy format");
            day = Convert.ToDateTime(Console.ReadLine()).Date;

            TimeSpan calculate = day.Subtract(arrival);

            Console.WriteLine("Your time difference in days is " + calculate.Days + " Days ago");
            Console.WriteLine("Your time difference in hours is " + calculate.Days*24 + " Hours ago");
            Console.WriteLine("Your time difference in minutes is " + calculate.Days* 24*60 + " Minutes ago");

            Console.ReadLine();
        }
    }
}
