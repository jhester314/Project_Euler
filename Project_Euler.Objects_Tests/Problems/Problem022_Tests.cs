using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem022_Tests
  {
    private Problem022 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem022();
    }
    
    [TestCase(1, 0)]
    public void Solve022_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem022Input(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
