using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem003Input([property: Range(1, long.MaxValue)] long Number);

  public class Problem003 : Problem<Problem003Input, long>
  {
    public override int Number => 3;
    public override string Name => "Largest prime factor";

    public override long Solve(Problem003Input input)
    {      
      var factors = Tools.Factor(input.Number);
      long result = factors.Any() ? factors.Max() : 1;
      
      return result;
    }
  }
}
