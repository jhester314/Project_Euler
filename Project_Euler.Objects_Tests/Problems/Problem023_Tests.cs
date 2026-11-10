using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem023_Tests
  {
    private Problem023 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem023();
    }
    
    [TestCase(1, 0)]
    public void Solve023_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem023Input(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
