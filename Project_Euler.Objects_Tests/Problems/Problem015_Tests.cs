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
      var result = _target.Solve(new Problem015Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
