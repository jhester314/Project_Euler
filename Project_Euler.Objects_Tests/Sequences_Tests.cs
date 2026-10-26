using System.Numerics;
using NUnit.Framework;
using Project_Euler.Objects;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Sequences_Tests
  {
    [TestCase(1, 1)]
    [TestCase(2, 1)]
    [TestCase(3, 2)]
    [TestCase(4, 3)]
    [TestCase(5, 5)]
    [TestCase(10, 55)]
    [TestCase(12, 144)]
    public void Fibonacci_ReturnsCorrectResult_Test(int n, int expected)
    {
      var results = Sequences.GetNthFibonacciTerm(n);
      Assert.AreEqual((BigInteger)expected, results);
    }

    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 5)]
    [TestCase(4, 7)]
    [TestCase(5, 11)]
    [TestCase(6, 13)]
    public void GetNthPrime(int n, int expected)
    {
      var results = Sequences.GetNthPrime(n);
      Assert.That(results, Is.EqualTo(expected));
    }

  }
}
