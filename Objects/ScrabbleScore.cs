using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ScrabbleScoreNS
{
  public class ScrabbleScore
  {
    public int Score(string wordInputted)
    {
      string word = wordInputted.ToUpper();
      char[] input = word.ToCharArray();
      string[] stringArray = Array.ConvertAll(input, element => element.ToString());
      int pointTotal = 0;
      Dictionary <int, string> points = new Dictionary<int, string> {
                                        {1, "AEIOULNRST"},
                                        {2, "DG"},
                                        {3, "BCMP"},
                                        {4, "FHVWY"},
                                        {5, "K"},
                                        {8, "JX"},
                                        {10, "QZ"}
                                      };
      foreach(var item in points)
      {
        for (int i = 0 ; i < stringArray.Length; i++)
        {
          if(item.Value.Contains(stringArray[i]))
          {
            pointTotal += item.Key;
            Console.WriteLine(item.Key);

          }
        }
      }
        // Console.WriteLine(pointTotal);
        return pointTotal;
    }
  }
}
