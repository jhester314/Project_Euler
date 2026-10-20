using System.Collections.Generic;
using System.Linq;
using Project_Euler.Objects;

namespace Project_Euler.Objects.Problems
{
  public class Problem003 : IProblem
  {
    public List<ArgType> GetArgTypes()
    {
      return new List<ArgType>() { ArgType.PositiveInteger };
    }

    public List<string> Solve(List<Argument> args)
    {
      List<string> results = new List<string>();
      long input;
      long result = 0;

      if (long.TryParse(args.First().Value.ToString(), out input))
      {
        result = Tools.GetLargestPrimeFactor(input);
      }

      results.Add(result.ToString());

      return results;
    }
  }
}

