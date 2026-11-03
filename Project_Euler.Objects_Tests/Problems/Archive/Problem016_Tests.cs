using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem016_Tests
  {
    private Problem016 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem016();
    }
    
    [TestCase(0, 1)]
    [TestCase(1, 2)]
    [TestCase(2, 4)]
    [TestCase(4, 7)]
    [TestCase(10, 7)]
    [TestCase(15, 26)]
    public void Solve016_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem016Input(input, false));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
