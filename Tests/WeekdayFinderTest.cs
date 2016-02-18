using System;
using System.Collections.Generic;
using Xunit;

namespace WeekdayFinderNS
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void dayFinder()
    {
      WeekdayFinder test = new WeekdayFinder();
      Assert.Equal("Thursday", test.DayFinder("2/18/2016"));
    }

  }
}
