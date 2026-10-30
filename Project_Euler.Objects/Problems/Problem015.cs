using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem015Input([property: Range(1, int.MaxValue)] int Limit);

  public class Problem015 : Problem<Problem015Input, int>
  {
    public override int Number => 15;
    public override string Name => "Lattice Paths";

    public override int Solve(Problem015Input input)
    {
      var result = 0;
      

      return result;
    }
    
    
    
  }
}
