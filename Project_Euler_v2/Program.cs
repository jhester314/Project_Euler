using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using Project_Euler.Objects;

namespace Project_Euler
{
  class Program
  {
    static void Main(string[] args)
    {

      var problems = DiscoverProblems();

      while (true)
      {
        Console.Write("Enter problem to solve (0 to exit): ");
        var problemText = Console.ReadLine();

        if (problemText is null)
        {
          break;
        }

        if (!int.TryParse(problemText, out var problemNumber))
        {
          Console.WriteLine("Please enter a valid problem number.");
          continue;
        }

        if (problemNumber <= 0)
        {
          break;
        }

        if (!problems.TryGetValue(problemNumber, out var problem))
        {
          Console.WriteLine($"Problem {problemNumber:D3} has not been implemented.");
          continue;
        }

        Console.WriteLine($"Selected Problem {problem.Number:D3}: {problem.Name}");

        while (true)
        {
          Console.Write("Enter input values (blank to choose another problem): ");
          var input = Console.ReadLine();

          if (input is null)
          {
            Console.WriteLine("Exiting..");
            return;
          }

          if (string.IsNullOrWhiteSpace(input))
          {
            break;
          }

          try
          {
            var stopwatch = Stopwatch.StartNew();
            var result = problem.SolveFromInput(input);
            stopwatch.Stop();

            Console.WriteLine("----CALCULATED ANSWER----");
            Console.WriteLine(result);
            Console.WriteLine($"Execution time: {stopwatch.Elapsed.TotalMilliseconds:F3} ms");
            Console.WriteLine("--------------------\n");
          }
          catch (FormatException exception)
          {
            Console.WriteLine($"Invalid input: {exception.Message}");
          }
          catch (ValidationException exception)
          {
            Console.WriteLine($"Invalid input: {exception.Message}");
          }
        }
      }

      Console.WriteLine("Exiting..");
    }

    private static Dictionary<int, IProblem> DiscoverProblems()
    {
      var problems = new Dictionary<int, IProblem>();
      var problemTypes = typeof(IProblem).Assembly
        .GetTypes()
        .Where(type =>
          !type.IsAbstract &&
          !type.IsInterface &&
          typeof(IProblem).IsAssignableFrom(type));

      foreach (var problemType in problemTypes)
      {
        if (Activator.CreateInstance(problemType) is not IProblem problem)
        {
          throw new InvalidOperationException(
            $"Could not create problem type '{problemType.FullName}'.");
        }

        if (problem.Number <= 0)
        {
          throw new InvalidOperationException(
            $"Problem type '{problemType.FullName}' must have a valid problem number.");
        }

        if (!problems.TryAdd(problem.Number, problem))
        {
          throw new InvalidOperationException(
            $"More than one problem exists with problem number {problem.Number:D3}.");
        }
      }

      return problems;
    }
  }
}