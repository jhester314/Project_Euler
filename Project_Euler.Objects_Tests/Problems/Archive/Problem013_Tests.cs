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
    
    [TestCase(1, "5537376230")]
    public void Solve013_ReturnsExpectedResults(int input, string expected)
    {
      var result = _target.Solve(new Problem013Input(input));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
