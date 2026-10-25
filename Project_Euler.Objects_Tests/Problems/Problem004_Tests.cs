using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem004_Tests
  {
    private Problem004 _target = null!;

    [SetUp]
    public void SetUp()
    {
      _target = new Problem004();
    }

    [TestCase(-1, 0)]
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(9, 9)]
    [TestCase(11, 121)]
    [TestCase(99, 9009)]
    [TestCase(999, 906609)]
    public void Solve004ReturnsExpectedValues(int input, int expected)
    {
      var result = _target.Solve(new Problem004Input(input));

      Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve004FromInputReturnsCorrectAnswer()
    {
      var result = _target.SolveFromInput("99");

      Assert.That(result, Is.EqualTo("9009"));
    }

  }
}

