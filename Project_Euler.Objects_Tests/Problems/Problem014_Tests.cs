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
    
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(4, 3)]
    [TestCase(5, 6)]
    [TestCase(13, 10)]
    public void GetCollatzStepCount_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.GetCollatzStepCount(input);
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
