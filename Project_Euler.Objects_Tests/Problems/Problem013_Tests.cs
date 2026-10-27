using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem013_Tests
  {
    private Problem013 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem013();
    }
    
    [TestCase(1, 0)]
    public void Solve013_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem013Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
