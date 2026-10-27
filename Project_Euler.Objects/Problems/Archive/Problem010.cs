using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem010Input([property: Range(1, int.MaxValue)] int Limit);

  public class Problem010 : Problem<Problem010Input, long>
  {
    public override int Number => 10;
    public override string Name => "Summation of Primes";

    public override long Solve(Problem010Input input)
    {
      long result = 0;
      
      if (input.Limit < 2)
      {
        result = 0;
      } 
      else
      {
        result = 2;
        for(int i = 3; i <= input.Limit; i += 2)
        {
          if (Tools.IsPrime(i))
            result += i;
        }
      }      

      return result;
    }
  }
}
