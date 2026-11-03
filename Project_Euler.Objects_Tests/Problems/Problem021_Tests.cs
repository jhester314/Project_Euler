using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem021_Tests
  {
    private Problem021 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem021();
    }
    
    [TestCase(300, 504)]
    public void Solve021_ReturnsExpectedResults(int input, int expected)
    {
      var result = _target.Solve(new Problem021Input(input, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
