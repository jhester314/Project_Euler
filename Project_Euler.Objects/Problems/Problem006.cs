using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem006Input([property: Range(1, int.MaxValue)] int Limit);

  public class Problem006 : Problem<Problem006Input, int>
  {
    public override int Number => 6;
    public override string Name => "Sum Square Difference";

    public override int Solve(Problem006Input input)
    {
      var sumOfSquares = 0;
      var sum = 0;
      
      for(int i = 1; i <= input.Limit; i++)
      {
        sumOfSquares += (int)Math.Pow(i, 2);
        sum += i;
      }
      var squareOfSums = (int)Math.Pow(sum, 2);
      
      var result = squareOfSums - sumOfSquares;
      return result;
    }

  }
}

