using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem016Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem016 : Problem<Problem016Input, int>
  {
    public override int Number => 16;
    public override string Name => "Power Digit Sum";

    public override int Solve(Problem016Input input)
    {
      var result = 0;
      BigInteger value = 1;
      
      for(int i = 1; i <= input.Limit; i++)
      {
        value *= 2;
      }
      
      while(value > 0)
      {
        result += (int)(value % 10);
        value /= 10;
      }

      return result;
    }
  }
}
