using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Euler.Objects.Problems
{
  public sealed record Problem015Input([property: Range(1, int.MaxValue)] int Limit, bool Debug = false);

  public class Problem015 : Problem<Problem015Input, long>
  {
    public override int Number => 15;
    public override string Name => "Lattice Paths";

    private Dictionary<Tuple<int, int>, long> _latticeScores = new ();

    public override long Solve(Problem015Input input)
    {
      long result = 0;
      
      result = GetLatticeScore(input.Limit, input.Limit);      

      return result;
    }
    
    public long GetLatticeScore(int n, int m)
    {
      long result = 0;
      if (m > n)
      {
        var l = n;
        n = m;
        m = l;
      }
      
      var nm = new Tuple<int, int>(n, m);
      if (m <= 1)
      {
        result = n + 1;
      }      
      else if (_latticeScores.ContainsKey(nm))
      {
        result = _latticeScores[nm];
      }
      else
      {
        result = GetLatticeScore(n-1, m) + GetLatticeScore(n, m-1);
        _latticeScores.Add(nm, result);
      }
      
      return result;
    }
    
    
  }
}
