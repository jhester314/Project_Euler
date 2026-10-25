using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record ProblemXXXInput([property: Range(1, int.MaxValue)] int Limit);

  public sealed class ProblemXXX : Problem<ProblemXXXInput, int>
  {
    public override int Number => 123456;
    public override string Name => "Template";

    public override int Solve(ProblemXXXInput input)
    {
      var result = 0;
      

      return result;
    }
  }
}
