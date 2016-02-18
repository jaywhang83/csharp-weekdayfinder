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
      Assert.Equal("Thursday", test.DayFinder("2", "18", "2016"));
    }
    [Fact]
    public void DayFinder_fail()
    {
      WeekdayFinder test = new WeekdayFinder();
      Assert.Equal("Not a valid input. Please enter a number only", test.DayFinder("2", "18", "fsdf"));
    }

    [Fact]
    public void DayFinder_fail2()
    {
      WeekdayFinder test = new WeekdayFinder();
        Assert.Equal("Not a valid input. Please enter a number only", test.DayFinder("2", "{}", "2016"));
    }

    [Fact]
    public void DayFinder_fail3()
    {
      WeekdayFinder test = new WeekdayFinder();
        Assert.Equal("Not a valid input. Please enter a number only", test.DayFinder("23fds", "18", "2016"));
    }
    [Fact]
    public void DayFinder_blank_space_fail()
    {
      WeekdayFinder test = new WeekdayFinder();
        Assert.Equal("Not a valid input. Please enter a number only", test.DayFinder(" ", "18", " "));
    }


  }
}
