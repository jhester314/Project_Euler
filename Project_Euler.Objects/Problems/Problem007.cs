using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem007Input([property: Range(1, int.MaxValue)] int Input);

  public sealed class Problem007 : Problem<Problem007Input, int>
  {
    public override int Number => 7;
    public override string Name => "10001st Prime";

    public override int Solve(Problem007Input input)
    {
      var result = Sequences.GetNthPrime(input.Input);      

      return result;
    }
  }
}


