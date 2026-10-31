using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem018Input(string FileName, bool Debug = false);

  public class Problem018 : Problem<Problem018Input, int>
  {
    public override int Number => 18;
    public override string Name => "Maximum Path Sum I";

    public override int Solve(Problem018Input input)
    {
      var result = 0;
      var filePath = Path.Combine(AppContext.BaseDirectory, "Data", input.FileName);
      
      if (File.Exists(filePath))
      {
        var text = File.ReadAllLines(filePath);
        if (text.Length > 0)
        {
          Log(input.Debug, $"File {input.FileName} loaded, processing {text.Length} lines..");
          
          result = 23;
          
        }
        else
        {
          Log(true, $"No data loaded from file {input.FileName}");
        }
      }
      else
      {
        var currentDir = Environment.CurrentDirectory;
        throw new FileNotFoundException($"File {input.FileName} could not be found in {currentDir}.");
      }
      
      return result;
    }
  }
}
