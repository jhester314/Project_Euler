using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem006_Tests
  {
    private Problem006 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem006();
    }
    
    [TestCase(1, 0)]
    [TestCase(2, 4)]
    [TestCase(3, 22)]
    [TestCase(10, 2640)]
    public void Solve006_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem006Input(input));
      Assert.That(result, Is.EqualTo(result));
    } 
    
  }  
}

