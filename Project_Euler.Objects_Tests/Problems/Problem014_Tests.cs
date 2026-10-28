using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem014_Tests
  {
    private Problem014 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem014();
    }
    
    [TestCase(1, 0)]
    public void Solve014_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem014Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
