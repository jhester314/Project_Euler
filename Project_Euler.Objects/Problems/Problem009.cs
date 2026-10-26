using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem009Input([property: Range(1, int.MaxValue)] int Limit);

  public class Problem009 : Problem<Problem009Input, int>
  {
    public override int Number => 9;
    public override string Name => "Special Pythagorean Triplet";

    public override int Solve(Problem009Input input)
    {
      var result = 0;
    
      for (int a = input.Limit - 2; a > 0; a--)
      {
        for (int b = a-1; b > 0; b--)
        {
          for (int c = b; c > 0; c--)
          {
            if (a + b + c == 1000)
              if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
              {
                Console.WriteLine($"Solution found: c: {c} | b: {b} | a: {a}");  
                Console.WriteLine($"Product: {a * b * c}");
                result = a*b*c;
              }            
          }
        }
      }      

      return result;
    }
  }
}
