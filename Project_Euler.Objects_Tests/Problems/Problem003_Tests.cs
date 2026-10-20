using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Project_Euler.Objects.Problems;

namespace Project_Euler.Objects.Tests
{
  [TestFixture]
  public class Problem003_Tests
  {
    private Problem003 _target;

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
