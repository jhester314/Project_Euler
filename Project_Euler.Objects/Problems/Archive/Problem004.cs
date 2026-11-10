using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem004Input([property: Range(1, int.MaxValue)] int Limit);

  public class Problem004 : Problem<Problem004Input, int>
  {
    public override int Number => 4;
    public override string Name => "Largest palindrome product";

    public override int Solve(Problem004Input input)
    {
      var result = 0;
      var product = 0;

      for (int i = input.Limit; i > 0; i--)
      {
        for (int j = i; j > 0; j--)
        {
          product = i * j;
          
          if (Tools.IsPalindrome(product) && product > result)
          {
            result = product;
          }
        }
      }

      return result;
    }
        
  }
}


