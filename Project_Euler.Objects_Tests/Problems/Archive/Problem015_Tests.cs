using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem015_Tests
  {
    private Problem015 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem015();
    }
    
    [TestCase(1, 2)]
    [TestCase(2, 6)]
    [TestCase(3, 20)]
    public void Solve015_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem015Input(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
    [TestCase(1, 1, 2)]
    [TestCase(2, 1, 3)]
    [TestCase(1, 2, 3)]
    [TestCase(2, 2, 6)]
    [TestCase(3, 2, 10)]
    [TestCase(2, 3, 10)]
    [TestCase(3, 3, 20)]
    public void GetLatticeScore_ReturnsExpectedResults(int n, int m, long expected)
    {
      var result = _target.GetLatticeScore(n, m);
      Assert.That(result, Is.EqualTo(expected));
    }
    
  }  
}
