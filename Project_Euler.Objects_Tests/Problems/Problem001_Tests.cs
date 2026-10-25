using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem001_Tests
  {
    private Problem001 _target = null!;

    [SetUp]
    public void SetUp()
    {
      _target = new Problem001();
    }

    [TestCase(5, 3)]
    [TestCase(6, 8)]
    [TestCase(10, 23)]
    public void Solve001ReturnsExpectedValues(int limit, int expected)
    {
      var result = _target.Solve(new Problem001Input(limit));

      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve001FromInputBindsRecordAndReturnsAnswer()
    {
      var input = "10";
      var expected = "23";
      var result = _target.SolveFromInput(input);

      Assert.That(result, Is.EqualTo(expected));
    }

  }
}
