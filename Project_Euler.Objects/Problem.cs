using System;
using System.Globalization;

namespace Project_Euler.Objects
{
  public interface IProblem
  {
    int Number { get; }
    string Name { get; }
    string SolveFromInput(string input);
  }

  public abstract class Problem<TInput, TResult> : IProblem
    where TInput : notnull
    where TResult : notnull
  {
    public abstract int Number { get; }
    public abstract string Name { get; }

    public abstract TResult Solve(TInput input);

    public string SolveFromInput(string input)
    {
      var parsedInput = ProblemInputBinder.Bind<TInput>(input);
      var result = Solve(parsedInput);

      return result switch
      {
        IFormattable formattable =>
          formattable.ToString(null, CultureInfo.InvariantCulture),
        _ => result.ToString() ?? string.Empty
      };
    }
  }
}
