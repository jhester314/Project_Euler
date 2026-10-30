using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem0XXInput([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem0XX : Problem<Problem0XXInput, int>
  {
    public override int Number => 123456;
    public override string Name => "Template";

    public override int Solve(Problem0XXInput input)
    {
      var result = 0;
      

      return result;
    }
  }
}
