using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem001Input([property: Range(1, int.MaxValue)] int Limit);

  public sealed class Problem001 : Problem<Problem001Input, int>
  {
    public override int Number => 1;
    public override string Name => "Multiples of 3 or 5";

    public override int Solve(Problem001Input input)
    {
      var total = 0;
      for (var i = 1; i < input.Limit; i++)
      {
        if ((i % 3 == 0) || (i % 5 == 0))
          total += i;
      }

      return total;
    }
  }
}
