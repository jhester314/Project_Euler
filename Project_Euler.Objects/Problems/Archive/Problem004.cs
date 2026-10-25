using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem004Input([property: Range(1, int.MaxValue)] int Digits);

  public class Problem004 : Problem<Problem004Input, int>
  {
    public override int Number => 4;
    public override string Name => "Largest palindrome product";

    public override int Solve(Problem004Input input)
    {
      var result = Tools.GetLargestPalindromeProduct(input.Digits);
      return result;
    }
  }
}


