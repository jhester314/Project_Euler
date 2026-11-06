using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem022Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem022 : Problem<Problem022Input, int>
  {
    public override int Number => 22;
    public override string Name => "Names Scores";

    public override int Solve(Problem022Input input)
    {
      var result = 0;
      

      return result;
    }
  }
}
