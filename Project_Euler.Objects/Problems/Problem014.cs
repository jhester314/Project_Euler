using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem014Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem014 : Problem<Problem014Input, int>
  {
    public override int Number => 14;
    public override string Name => "Longest Collatz Sequence";

    public override int Solve(Problem014Input input)
    {
      var result = 0;
      

      return result;
    }
  }
}
