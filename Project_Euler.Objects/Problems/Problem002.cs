using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project_Euler.Objects.Problems
{
  public class Problem002 : IProblem
  {
    public List<ArgType> GetArgTypes()
    {
      return new List<ArgType>() { ArgType.PositiveInteger };
    }

    public List<string> Solve(List<Argument> input)
    {
      List<string> results = new List<string>();
      int limit;
      BigInteger result = 0;
      Sequences sequences = new Sequences();

      if (int.TryParse(input.First().Value.ToString(), out limit))
      {
        BigInteger fib = 1;
        for (int i = 1; fib <= limit; i++)
        {
          if (fib % 2 == 0)
            result += fib;

          fib = sequences.GetFibonacciTerm(i);
        }
      }

      results.Add(result.ToString());

      return results;
    }

  }
}
