using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem017Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem017 : Problem<Problem017Input, int>
  {
    public override int Number => 17;
    public override string Name => "Number Letter Counts";

    public override int Solve(Problem017Input input)
    {
      var result = 0;
      

      return result;
    }
  }
}
