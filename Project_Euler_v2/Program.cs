using System.Diagnostics;
using System.Reflection;
using Project_Euler.Objects;
using Project_Euler.Objects.Problems;

namespace Project_Euler
{
  class Program
  {
    static void Main(string[] args)
    {
      bool exit = false;

      while (!exit)
      {
        int problemNumber = 0;
        Console.WriteLine("Enter problem to solve: ");
        var inputProblem = Console.ReadLine();

        if (!int.TryParse(inputProblem, out problemNumber) || problemNumber <= 0)
        {
          exit = true;
        }
        else
        {
          var className = $"Project_Euler.Objects.Problems.Problem{problemNumber:D3}";
          // Anchor to any known type in the same assembly
          var assembly = typeof(Problem001).Assembly;

          var type = assembly.GetType(className);

          if (type is null)
          {
            Console.WriteLine($"Type '{className}' not found.");
            return;
          }

          if (!typeof(IProblem).IsAssignableFrom(type))
          {
            Console.WriteLine($"Type '{className}' does not implement IProblem.");
            return;
          }

          var instance = Activator.CreateInstance(type) as IProblem;
          if (instance is null)
          {
            Console.WriteLine($"Could not instantiate '{className}'.");
            return;
          }

          if (instance != null)
          {
            while (!exit)
            {
              Console.WriteLine($"Enter input: ");
              var inputArgs = Console.ReadLine();

              var expectedArgTypes = instance.GetArgTypes();
              var actualArgs = Validator.ValidateAndParseArgs(expectedArgTypes, inputArgs);
              List<string> results;
              TimeSpan? solveDuration = null;

              if (actualArgs.Any(x => !String.IsNullOrWhiteSpace(x.Error)))
              {
                results = actualArgs.Where(x => !String.IsNullOrWhiteSpace(x.Error))
                    .Select(x => x.Error).ToList();
              }
              else
              {
                var stopwatch = Stopwatch.StartNew();
                results = instance.Solve(actualArgs);
                stopwatch.Stop();
                solveDuration = stopwatch.Elapsed;
              }

              Console.WriteLine("----CALCULATED ANSWER----");
              foreach (var result in results)
              {
                Console.WriteLine(result);
              }
              if (solveDuration.HasValue)
              {
                Console.WriteLine($"Execution time: {solveDuration.Value.TotalMilliseconds:F3} ms");
              }
              Console.WriteLine("--------------------\n");
            }

          }
          else
          {
            Console.WriteLine("{0} has not been implemented yet. \n", className);
          }
        }
      }
      Console.WriteLine("Exiting..");
    }
  }
}
