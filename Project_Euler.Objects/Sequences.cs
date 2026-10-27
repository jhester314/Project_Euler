using System.Numerics;

namespace Project_Euler.Objects
{
  public static class Sequences
  {
    public static BigInteger GetNthFibonacciTerm(int n)
    {
      BigInteger result = 0;
      if (n < 3)
      {
        result = 1;
      }
      else
      {
        BigInteger n_2 = 1;
        BigInteger n_1 = 1;
        for (int i = 3; i <= n; i++)
        {
          result = n_2 + n_1;
          n_2 = n_1;
          n_1 = result;          
        }
      }
      return result;
    }
  
    public static int GetNthPrime(int n)
    {
      var result = 1;
            
      if (n == 1)
      {
        result = 2;
      }
      else 
      {
        var primeCount = 1;        
        for (int i = 3; primeCount < n; i += 2)
        {
          if (Tools.IsPrime(i))
          {
            primeCount++;
            result = i;
          }
        }
      }
      return result;
    }
  
    public static int GetNthTriangleTerm(int n)
    {
      var result = 1;
      
      for(int i = 2; i < n; i++)
        result += i;
      
      return result;
    }
  
  }
}
