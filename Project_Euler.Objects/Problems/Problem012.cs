using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem012Input([property: Range(1, int.MaxValue)] int DivisorCount, bool Debug = false);

  public class Problem012 : Problem<Problem012Input, int>
  {
    public override int Number => 12;
    public override string Name => "Highly Divisible Triangular Number";

    public override int Solve(Problem012Input input)
    {
      var result = 0;
      var triangleNum = 1;
      var highestDivisor = 0;
      
      if (input.DivisorCount < 2)
      {
        result = 1;
      }
      else
      {
        for(int i = 2; result == 0; i++)
        {
          triangleNum += i;
          
          var factorCounts = Tools.FactorWithDistinctCounts(triangleNum);
          
          var numberOfDivisors = 1;
          foreach(var factor in factorCounts)
          {
            numberOfDivisors *= (factor.Value + 1);
          }
          
          if (numberOfDivisors > highestDivisor)
          {
            highestDivisor = numberOfDivisors;
            Log(input.Debug, $"New HighestDivisor: {highestDivisor} | i: {i}  | triangleNumber: {triangleNum}");
          }
          
          if (highestDivisor >= input.DivisorCount)
            result = triangleNum;
                      
          if (i % 1000 == 0)
             Log(input.Debug, $"Progress - i: {i}  | triangleNumber: {triangleNum} | divisors: {numberOfDivisors}");
        }
      }      

      return result;
    }
  }
}
