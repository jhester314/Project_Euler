using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem018_Tests
  {
    private Problem018 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem018();
    }
    
    [Test]
    public void Solve018_ReturnsExpectedResults()
    {
      var testFileName = "0018_triangle_test.txt";
      var expected = 23;
      var result = _target.Solve(new Problem018Input(testFileName, true));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
