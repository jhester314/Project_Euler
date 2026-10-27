using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem011_Tests
  {
    private Problem011 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem011();
    }
    
    // [TestCase(1, 99)]
    // [TestCase(2, 9603)]
    [TestCase(1, 99)]
    [TestCase(2, 6650)]
    public void Solve011_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem011Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
