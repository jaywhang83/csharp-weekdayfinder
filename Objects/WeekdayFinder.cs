using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WeekdayFinderNS
{
  public class WeekdayFinder
  {
    public string DayFinder(string month, string date, string year)
    {
      int monthInt = 0;
      int dateInt = 0;
      int yearInt = 0;
      try
      {
        monthInt = int.Parse(month);
        dateInt = int.Parse(date);
        yearInt = int.Parse(year);
      }
      catch(FormatException e) when (e is FormatException)
      {
        Console.WriteLine("Not a valid input. Please enter a number only");
        return "Not a valid input. Please enter a number only"; 
      }

      DateTime day = new DateTime(yearInt, monthInt, dateInt);
      // string  dayToFind = Regex.Replace(dayToFindInputted, @"[^\w]", " ").Trim();
      Console.WriteLine(day.DayOfWeek.ToString());
      return day.DayOfWeek.ToString();
    }
  }
}


// DateTime time = new DateTime(2003, 5, 1);
// Console.WriteLine(time.DayOfWeek);
