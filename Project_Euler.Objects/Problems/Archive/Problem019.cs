using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem019Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem019 : Problem<Problem019Input, int>
  {
    public override int Number => 19;
    public override string Name => "Counting Sundays";

    public override int Solve(Problem019Input input)
    {
      var result = 0;
      
      for(int year = 1901; year <= 2000; year++)
      {
        for(int month = 1; month <= 12; month++)
        {
          var first = new DateTime(year, month, 1);
          
          if (first.DayOfWeek == DayOfWeek.Sunday)
            result++;
          
        }
      }
      
      return result;
    }
  }
}
