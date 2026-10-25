using System.Numerics;
using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem002_Tests
  {
    private Problem002 _target = null!;

    [SetUp]
    public void SetUp()
    {
      _target = new Problem002();
    }

    [TestCase(2, 2)]
    [TestCase(3, 2)]
    [TestCase(10, 10)]
    [TestCase(90, 44)]
    public void Solve002ReturnsExpectedValues(int input, int expected)
    {
      var result = _target.Solve(new Problem002Input(input));

      Assert.That(result, Is.EqualTo(new BigInteger(expected)));
    }

    [Test]
    public void Solve002FromInputBindsRecordAndReturnsAnswer()
    {
      var result = _target.SolveFromInput("10");

      Assert.That(result, Is.EqualTo("10"));
    }

  }
}
