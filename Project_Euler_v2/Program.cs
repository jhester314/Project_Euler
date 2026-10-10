using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Problems;
using Project_Euler.Objects;

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
          var className = $"Problem{problemNumber:D3}";
          var nameSpace = "Problems";

          Assembly? assembly = null;
          try
          {
            assembly = Assembly.Load(nameSpace);
          }
          catch
          {
            Console.WriteLine($"Could not load assembly '{nameSpace}'.");
          }

          Type? type = assembly.GetType($"{nameSpace}.{className}");
          if (type is null)
          {
            Console.WriteLine($"Type '{nameSpace}.{className}' not found.");
          }

          if (!typeof(IProblem).IsAssignableFrom(type))
          {
            Console.WriteLine($"Type '{className}' does not implement IProblem.");
          }

          IProblem? instance = Activator.CreateInstance(type) as IProblem;
          if (instance is null)
          {
            Console.WriteLine($"Could not instantiate '{className}'.");
          }

          if (instance != null)
          {
            Console.WriteLine("Enter arguments: ");
            var inputArgs = Console.ReadLine();

            var expectedArgTypes = instance.GetArgTypes();
            var actualArgs = Validator.ValidateAndParseArgs(expectedArgTypes, inputArgs);
            List<string> results;

            if (actualArgs.Any(x => !String.IsNullOrWhiteSpace(x.Error)))
            {
              results = actualArgs.Where(x => !String.IsNullOrWhiteSpace(x.Error))
                  .Select(x => x.Error).ToList();
            }
            else
            {
              results = instance.Solve(actualArgs);
            }

            Console.WriteLine("--------------------");
            foreach (var result in results)
            {
              Console.WriteLine(result);
            }
            Console.WriteLine("--------------------\n");

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
