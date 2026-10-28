using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem014Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem014 : Problem<Problem014Input, long>
  {
    public override int Number => 14;
    public override string Name => "Longest Collatz Sequence";

    private Dictionary<long, long> _termCounts = new();

    public override long Solve(Problem014Input input)
    {
      long result = 1;
      long highestCount = 0;
      
      for(long i = 2; i <= input.Limit; i++)
      {
        long iStepCount = GetCollatzStepCount(i);
        
        if (highestCount < iStepCount)
        {
          highestCount = iStepCount;
          result = i;
          Log(input.Debug, $"HighestCount updated: i : {i} | steps: {iStepCount} | termCount Entries: {_termCounts.Count} | HighestEntry: {_termCounts.Keys.Max()}");
        }
      }

      return result;
    }
    
    public long GetCollatzStepCount(long n)
    {
      long result = 0;
      if (n <= 1)
      {
        result = 1;
      }      
      else if (_termCounts.ContainsKey(n))
      {
        result = _termCounts[n];
      }
      else
      {
        long n_1 = Sequences.GetNextCollatzTerm(n);
        long n_1_stepCount = GetCollatzStepCount(n_1);
        result = n_1_stepCount + 1;
        _termCounts.Add(n, result);
      }
      return result;
    }
    
  }
}
