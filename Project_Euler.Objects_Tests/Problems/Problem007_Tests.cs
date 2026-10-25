using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem007_Tests
  {
    private Problem007 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem007();
    }
    
    [TestCase(1, 0)]
    public void Solve007_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem007Input(input));
      Assert.That(result, Is.EqualTo(result));
    } 
    
  }  
}
