using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem012_Tests
  {
    private Problem012 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem012();
    }
    
    [TestCase(1, 1)]
    [TestCase(2, 3)]
    [TestCase(3, 6)]
    [TestCase(4, 6)]
    [TestCase(5, 28)]
    public void Solve012_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem012Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
