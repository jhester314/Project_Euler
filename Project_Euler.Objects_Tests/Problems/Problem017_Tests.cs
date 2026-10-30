using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem017_Tests
  {
    private Problem017 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem017();
    }
    
    [TestCase(1, 3)]
    [TestCase(2, 6)]
    [TestCase(3, 11)]
    [TestCase(4, 15)]
    [TestCase(5, 19)]
    public void Solve017_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem017Input(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
