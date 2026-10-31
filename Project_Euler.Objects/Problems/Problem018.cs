using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

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
        var blob = File.ReadAllText(filePath);
        if (blob.Length > 0)
        {
          var triangle = Tools.ConvertBlobToMatrix(blob);
          var pathValues = new int[triangle.GetLength(1)];
          var rowPathValues = new int[triangle.GetLength(1)];
          
          Log(input.Debug, $"File {input.FileName} loaded, processing {triangle.Length} elements..");
          
          for(int row = 0; row < triangle.GetLength(0); row++)
          {
            for(int column = 0; column < triangle.GetLength(1); column++)
            {
              var higherPathA = (column > 0) ? pathValues[column-1] : 0;
              var higherPathB = pathValues[column];
              var higherPath = Math.Max(higherPathA, higherPathB);
              
              var current = triangle[row, column];              
              rowPathValues[column] = current + higherPath;              
            }
            pathValues = (int[])rowPathValues.Clone();
            rowPathValues = new int[triangle.GetLength(1)];
          }
          
          result = pathValues.Max(x => x);          
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
