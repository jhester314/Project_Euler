using System;
using System.Diagnostics;
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
    private static readonly Stopwatch Timer = new();


    public abstract TResult Solve(TInput input);

    public string SolveFromInput(string input)
    {
      var parsedInput = ProblemInputBinder.Bind<TInput>(input);
      Timer.Restart();
      TResult result;
      try
      {
        result = Solve(parsedInput);  
      }
      catch(Exception ex)
      {
        Log(true, ex.Message);
        throw;
      }
      finally
      {
        Timer.Stop();
      }

      return result switch
      {
        IFormattable formattable =>
          formattable.ToString(null, CultureInfo.InvariantCulture),
        _ => result.ToString() ?? string.Empty
      };
    }
    
    public void Log(bool debug, string message)
    {
      if (debug)
        Console.WriteLine($"[{Timer.Elapsed:mm\\:ss\\.fff}] {message}");
    }
    
  }
}
