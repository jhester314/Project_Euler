using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler.Objects
{
  public static class Tools
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

    public static Dictionary<long, int> FactorWithDistinctCounts(long input)
    {
      var results = new Dictionary<long, int>();
      
      var factors = Factor(input);
      foreach(var factor in factors.Distinct())
      {
        results.Add(factor, factors.Count(x => x == factor));        
      }
      
      return results;
    }

    public static bool IsPrime(long input)
    {
      var result = false;
      
      if (input < 2)
      {
        result = false;
      }
      else if (input == 2 || input == 3 || input == 5)
      {
        result = true;
      }
      else if (input % 2 == 0 || input % 3 == 0)
      {
        result = false;
      }
      else
      {
        result = true;
        for(long i = 5; i <= input/i; i += 2)
        {          
          if (input % i == 0)
          {
            result = false;
            break;
          }          
        }
      }      
      
      return result;
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

    public static long GetProductFromIntString(string input)
    {
      long result = 1;
      var digits = new List<int>();
      
      for(int i = 0; i < input.Length; i++)
      {
        int j = 0;
        if (int.TryParse(input.Substring(i, 1), out j))
        {
          if (j > 0)
            digits.Add(j);
        }        
      }
      
      foreach(var d in digits)
        result *= d;
      
      return result;
    }

  }
}

