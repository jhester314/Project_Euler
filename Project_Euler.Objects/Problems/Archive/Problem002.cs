using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem002Input([property: Range(1, int.MaxValue)] int Limit);

  public class Problem002 : Problem<Problem002Input, BigInteger>
  {
    public override int Number => 2;
    public override string Name => "Even Fibonacci numbers";

    public override BigInteger Solve(Problem002Input input)
    {
      BigInteger result = 0;

      BigInteger fib = 1;
      for (var i = 1; fib <= input.Limit; i++)
      {
        if (fib % 2 == 0)
          result += fib;

        fib = Sequences.GetNthFibonacciTerm(i);
      }

      return result;
    }
  }
}
