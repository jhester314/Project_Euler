using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem021Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem021 : Problem<Problem021Input, int>
  {
    public override int Number => 21;
    public override string Name => "Amicable Numbers";

    private Dictionary<int, int> _divisorSums = null!;

    public override int Solve(Problem021Input input)
    {
      var result = 0;
      _divisorSums = new Dictionary<int, int>();
      
      for(int i = 1; i < input.Limit; i++)
      {
        var divisorList = Tools.GetDivisors(i);
        var sum = GetDivisorSum(divisorList);
        _divisorSums.Add(i, sum);
        if (i != sum && _divisorSums.ContainsKey(sum) 
          && _divisorSums[sum] == i )
        {
          Log(input.Debug, $"Found amicable pair: {i} | {sum}");
          result += i + sum;
        }
      }    

      return result;
    }
    
    public int GetDivisorSum(List<long> input)
    {
      var result = 0;
      input.Remove(input.Max());
      result = (int)input.Sum();
      
      return result;
    }
    
  }
}
