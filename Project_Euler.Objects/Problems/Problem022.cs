using System;
using System.IO;
using System.Linq;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem022Input(string FileName, bool Debug = false);

  public class Problem022 : Problem<Problem022Input, long>
  {
    public override int Number => 22;
    public override string Name => "Names Scores";

    public override long Solve(Problem022Input input)
    {
      long result = 0;
      var filePath = Path.Combine(AppContext.BaseDirectory, "Data", input.FileName);
      
      if (File.Exists(filePath))
      {
        var names = File.ReadAllText(filePath);
        if (names.Length > 0)
        {
          var nameList = names
            .Replace("\"", "")
            .Split(',')
            .Select(x => x.Trim())
            .OrderBy(x => x)
            .ToArray();
          for(int i = 0; i < nameList.Length; i++)
          {
            var nameScore = Tools.GetNameScore(nameList[i]);
            result += nameScore * (i + 1);
            if (i % 100 == 0) Log(input.Debug, $"i:{i} | current name:{nameList[i]} | current score:{result}");
          }
        }
        else
        {
          Log(true, $"No data loaded from file {input.FileName}");
        }        
      }
      else
      {
        Log(true, $"File {input.FileName} could not be found in {AppContext.BaseDirectory}\\Data.");
      }

      return result;
    }
  }
}
