using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem007Input([property: Range(1, int.MaxValue)] int Limit);

  public sealed class Problem007 : Problem<Problem007Input, int>
  {
    public override int Number => 1;
    public override string Name => "";

    public override int Solve(Problem007Input input)
    {
      var result = 0;
      

      return result;
    }
  }
}


