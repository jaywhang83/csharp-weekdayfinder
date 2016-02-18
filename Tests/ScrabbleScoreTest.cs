using System;
using System.Collections.Generic;
using Xunit;

namespace ScrabbleScoreNS
{
  public class ScrabbleScoreTest
  {
    [Fact]
    public void Score_SingleLetter()
    {
      ScrabbleScore test = new ScrabbleScore();
      Assert.Equal(1, test.Score("A"));
    }
    [Fact]
    public void Score_Word()
    {
      ScrabbleScore test = new ScrabbleScore();
      Assert.Equal(8, test.Score("HELLO"));
    }
  }
}
