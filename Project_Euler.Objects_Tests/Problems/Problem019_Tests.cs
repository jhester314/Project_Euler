using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem019_Tests
  {
    private Problem019 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem019();
    }
    
    [TestCase(1, 171)]
    public void Solve019_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem019Input(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
