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

                    var className = String.Format("Problem{0}", problemNumber.ToString("D3"));
                    var nameSpace = "Problems";
                    IProblem instance = null;

                    try
                    {
                        Assembly assembly = Assembly.Load(nameSpace);
                        Type type = assembly.GetType(String.Format("{0}.{1}", nameSpace, className));
                        instance = (IProblem)Activator.CreateInstance(type);
                    }
                    catch (Exception e)
                    {
                        instance = null;
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
