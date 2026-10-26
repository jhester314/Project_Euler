using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem008_Tests
  {
    private Problem008 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem008();
    }
    
    [TestCase(1, 9)]
    [TestCase(2, 81)]
    [TestCase(3, 648)]
    [TestCase(4, 5832)]
    public void Solve008_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem008Input(input));
      Assert.That(result, Is.EqualTo(result));
    } 
    
  }  
}
