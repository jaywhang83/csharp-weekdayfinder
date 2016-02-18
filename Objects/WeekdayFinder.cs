using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WeekdayFinderNS
{
  public class WeekdayFinder
  {
    public string DayFinder(string dayToFindInputted)
    {
      string  dayToFind = Regex.Replace(dayToFindInputted, @"[^\w]", " ");

      Console.WriteLine(dayToFind);
      return "here";
    }
  }
}


// DateTime time = new DateTime(2003, 5, 1);
// Console.WriteLine(time.DayOfWeek);
