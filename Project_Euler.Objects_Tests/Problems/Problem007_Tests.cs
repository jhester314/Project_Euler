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
    
    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 5)]
    [TestCase(4, 7)]
    [TestCase(5, 11)]
    [TestCase(6, 13)]
    [TestCase(10001, 104743)]
    public void Solve007_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem007Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
