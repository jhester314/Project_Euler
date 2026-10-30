using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem0XX_Tests
  {
    private Problem0XX _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem0XX();
    }
    
    [TestCase(1, 0)]
    public void Solve0XX_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem0XXInput(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
