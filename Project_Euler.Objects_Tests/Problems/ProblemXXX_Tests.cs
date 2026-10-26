using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class ProblemXXX_Tests
  {
    private ProblemXXX _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new ProblemXXX();
    }
    
    [TestCase(1, 0)]
    public void SolveXXX_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new ProblemXXXInput(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
