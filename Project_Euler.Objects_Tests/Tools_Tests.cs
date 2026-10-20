using NUnit.Framework;
using Project_Euler.Objects;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class Tools_Tests
  {
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(4, 2)]
    [TestCase(6, 3)]
    [TestCase(8, 2)]
    [TestCase(9, 3)]
    [TestCase(13195, 29)]
    public void GetLargestPrimeFactor_ReturnsCorrectResult_Test(long input, long expected)
    {
      var results = Tools.GetLargestPrimeFactor(input);
      Assert.AreEqual(expected, results);
    }

    [TestCase(1, new long[] { 1 })]
    [TestCase(2, new long[] { 2 })]
    [TestCase(3, new long[] { 3 })]
    [TestCase(4, new long[] { 2, 2 })]
    [TestCase(5, new long[] { 5 })]
    [TestCase(6, new long[] { 2, 3 })]
    [TestCase(8, new long[] { 2, 2, 2 })]
    [TestCase(9, new long[] { 3, 3 })]
    [TestCase(13, new long[] { 13 })]
    [TestCase(15, new long[] { 3, 5 })]
    [TestCase(26, new long[] { 2, 13 })]
    [TestCase(13195, new long[] { 5, 7, 13, 29 })]
    //[TestCase(600851475143, new long[] { 71, 839, 1471, 6857 })]
    public void Factor_ReturnsCorrectResult_Test(long input, long[] expected)
    {
      var results = Tools.Factor(input);
      Assert.AreEqual(expected, results);
    }
  }
}
