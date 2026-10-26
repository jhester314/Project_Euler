using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem010_Tests
  {
    private Problem010 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem010();
    }
    
    [TestCase(1, 0)]
    [TestCase(2, 2)]
    [TestCase(3, 5)]
    [TestCase(5, 10)]
    [TestCase(6, 10)]
    [TestCase(7, 17)]
    [TestCase(10, 17)]
    public void Solve010_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem010Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
