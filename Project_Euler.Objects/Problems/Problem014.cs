using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem014Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem014 : Problem<Problem014Input, int>
  {
    public override int Number => 14;
    public override string Name => "Longest Collatz Sequence";

    private Dictionary<int, int> _termCounts = new();

    public override int Solve(Problem014Input input)
    {
      var result = 0;
      var highestCount = 0;
      
      for(int i = 2; i <= input.Limit; i++)
      {
        var iStepCount = GetCollatzStepCount(i);
        
        if (highestCount < iStepCount)
        {
          highestCount = iStepCount;
          result = i;
          Log(input.Debug, $"HighestCount updated: i : {i} | steps: {iStepCount} | termCount Entries: {_termCounts.Count}");
        }        
      }

      return result;
    }
    
    public int GetCollatzStepCount(int n)
    {
      var result = 0;
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
        var n_1 = Sequences.GetNextCollatzTerm(n);
        var n_1_stepCount = GetCollatzStepCount(n_1);
        result = n_1_stepCount + 1;
        _termCounts.Add(n, result);
      }
      return result;
    }
    
  }
}
