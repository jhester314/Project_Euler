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
      for (long i = 3; i <= sqrt && input > 1; i += 2)
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

    public static int GetLargestPalindromeProduct(int limit)
    {
      var result = 0;
      var product = 0;

      for (int i = limit; i > 0; i--)
      {
        for (int j = i; j > 0; j--)
        {
          product = i * j;
          
          if (IsPalindrome(product) && product > result)
          {
            result = product;
          }
        }
      }

      return result;
    }
    
    public static bool IsPalindrome(int input)
    {
      var result = false;
      
      if (input >= 0)
      {
        int original = input;
        int reversed = 0;

        while (input > 0)
        {
          reversed = (reversed * 10) + (input % 10);
          input /= 10;
        }
        
        result = original == reversed;
      }
      
      return result;
    }


  }
}

