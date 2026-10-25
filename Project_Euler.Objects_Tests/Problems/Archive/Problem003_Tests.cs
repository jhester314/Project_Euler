using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem003_Tests
  {
    private Problem003 _target = null!;

    [SetUp]
    public void SetUp()
    {
      _target = new Problem003();
    }

    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(4, 2)]
    [TestCase(5, 5)]
    [TestCase(6, 3)]
    [TestCase(8, 2)]
    [TestCase(9, 3)]
    [TestCase(10, 5)]
    [TestCase(13195, 29)]
    public void Solve003_ReturnsExpectedResults(int input, long expected)
    {
      var result = _target.Solve(new Problem003Input(input));

      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve003FromInput_BindsRecordAndReturnsAnswer()
    {
      var result = _target.SolveFromInput("13195");

      Assert.That(result, Is.EqualTo("29"));
    }

  }
}
