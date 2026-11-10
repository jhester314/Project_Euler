using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem023Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem023 : Problem<Problem023Input, int>
  {
    public override int Number => 23;
    public override string Name => "Non-Abundant Sums";

    public override int Solve(Problem023Input input)
    {
      var result = 0;
      

      return result;
    }
  }
}
