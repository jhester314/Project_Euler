using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem022_Tests
  {
    private Problem022 _target = null!;
    
    [SetUp]
    public void SetUp()
    {
      _target = new Problem022();
    }
    
    [Test]
    public void Solve022_ReturnsExpectedResults()
    {
      var input = "0022_names_test.txt";
      var expected = 172;
      var result = _target.Solve(new Problem022Input(input, false));
      Assert.That(result, Is.EqualTo(expected));
    } 
    
  }  
}
