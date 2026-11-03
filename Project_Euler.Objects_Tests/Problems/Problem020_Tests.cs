using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem020_Tests
  {
    private Problem020 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem020();
    }
    
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 6)]
    [TestCase(4, 6)]
    [TestCase(10, 27)]
    public void Solve020_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem020Input(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
