using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem009_Tests
  {
    private Problem009 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem009();
    }
    
    [TestCase(12, 60)]
    [TestCase(1000, 31875000)]
    public void Solve009_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem009Input(input));
      Assert.That(result, Is.EqualTo(result));
    } 
    
  }  
}
