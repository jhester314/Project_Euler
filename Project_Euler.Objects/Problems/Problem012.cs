using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem012Input([property: Range(1, int.MaxValue)] int DivisorCount);

  public class Problem012 : Problem<Problem012Input, int>
  {
    public override int Number => 12;
    public override string Name => "Highly Divisible Triangular Number";

    public override int Solve(Problem012Input input)
    {
      var result = 0;
      var triangleNum = 0;
      
      if (input.DivisorCount < 2)
      {
        result = 1;
      }
      else
      {
        for(int i = 1; result == 0; i++)
        {
          triangleNum += i;
          
          var factorList = Tools.FactorWithDistinctCounts(triangleNum);
          
          var numberOfDivisors = factorList.Sum(x => x.Value);
          if (numberOfDivisors > input.DivisorCount)
            result = triangleNum; 
        }
      }      

      return result;
    }
  }
}
