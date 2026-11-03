using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem020Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem020 : Problem<Problem020Input, int>
  {
    public override int Number => 20;
    public override string Name => "Factorial Digit Sum";

    public override int Solve(Problem020Input input)
    {
      int result = 0;
      
      BigInteger factorial = Sequences.GetNthFactorial(input.Limit);
      while(factorial > 0)
      {
        BigInteger digit = factorial % 10;
        result += (int)digit;
        factorial /= 10;
      }

      return result;
    }
  }
}
