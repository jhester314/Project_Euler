using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem005Input([property: Range(1, long.MaxValue)] long Limit);
  
  public class Problem005 : Problem<Problem005Input, long>
  {
    public override int Number => 5;
    public override string Name => "Smallest Multiple";

    public override long Solve(Problem005Input input)
    {
      long result = 1;
      var factorsList = new Dictionary<long, int>();
      
      for (long i = input.Limit; i > 1; i--)
      {
        var factors = Tools.FactorWithDistinctCounts(i);
        
        foreach(var factor in factors)
        {
          if (factorsList.Keys.Contains(factor.Key))
          {
            factorsList[factor.Key] = Math.Max(factorsList[factor.Key], factor.Value);
          }
          else
          {
            factorsList.Add(factor.Key, factor.Value);
          }          
        }
      }
      
      foreach(var factor in factorsList)
        result *= (long)Math.Pow(factor.Key, factor.Value);
      
      return result;
    }
    
  }
  
}

