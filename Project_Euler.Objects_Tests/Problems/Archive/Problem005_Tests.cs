using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem005_Tests
  {
    private Problem005 _target = null!;
  
    [SetUp]
    public void SetUp()
    {
      _target = new Problem005();
    }
    
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 6)]
    [TestCase(4, 12)]
    [TestCase(5, 60)]
    [TestCase(6, 60)]
    [TestCase(7, 420)]
    [TestCase(8, 840)]
    [TestCase(9, 2520)]
    [TestCase(10, 2520)]
    [TestCase(11, 27720)]
    public void Solve005_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem005Input(input));
      Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Solve005FromInput_ReturnsCorrectAnswer()
    {
      var result = _target.SolveFromInput("10");
      Assert.That(result, Is.EqualTo("2520"));
    }
    
  }  
}
