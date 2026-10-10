using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Project_Euler.Objects;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Problem002_Tests
  {
    private Problem002 _target;

    [SetUp]
    public void SetUp()
    {
      _target = new Problem002();
    }

    [TestCase(2, 2)]
    [TestCase(3, 2)]
    [TestCase(10, 10)]
    [TestCase(90, 44)]
    public void SolveReturnsExpectedValues(int input, int expected)
    {
      var args = new List<Argument>()
            {
                new Argument()
                {
                    Type = ArgType.PositiveInteger,
                    Value = input
                }
            };
      var result = _target.Solve(args);
      Assert.AreEqual(expected.ToString(), result.First());
    }

  }
}
