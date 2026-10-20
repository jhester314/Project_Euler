using System.Collections.Generic;
using System.Linq;

namespace Project_Euler.Objects
{
  public class Tools
  {

    public static long GetLargestPrimeFactor(long input)
    {
      var factors = Factor(input);
      long result = factors.Any() ? factors.Max() : 1;

      return result;
    }

    public static List<long> Factor(long input)
    {
      List<long> results = new List<long>();

      if (input < 0)
      {
        input *= -1;
      }

      if (input < 2)
      {
        results.Add(input);
        return results;
      }

      while (input % 2 == 0)
      {
        results.Add(2);
        input /= 2;
      }

      var sqrt = (long)System.Math.Sqrt(input);
      for (long i = 3; i <= sqrt; i += 2)
      {
        if (input % i == 0)
        {
          results.Add(i);
          input /= i;
          i -= 2;
        }
      }

      if (input > 1) results.Add(input);

      return results;
    }

  }
}

