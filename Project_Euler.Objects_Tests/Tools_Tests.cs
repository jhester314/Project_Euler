using System.Collections.Generic;
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
    [TestCase(600851475143, 6857)]
    public void GetLargestPrimeFactor_ReturnsCorrectResult_Test(long input, long expected)
    {
      var results = Tools.GetLargestPrimeFactor(input);
      Assert.That(results, Is.EqualTo(expected));
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
    [TestCase(600851475143, new long[] { 71, 839, 1471, 6857 })]
    public void Factor_ReturnsCorrectResult_Test(long input, long[] expected)
    {
      var results = Tools.Factor(input);
      Assert.That(results, Is.EqualTo(expected));
    }
    
    
    private static IEnumerable<TestCaseData> FactorWithDistinctCountCases()
    {
      yield return new TestCaseData(2L, new Dictionary<long, int> { { 2L, 1 } });
      yield return new TestCaseData(3L, new Dictionary<long, int> { { 3L, 1 } });
      yield return new TestCaseData(6L, new Dictionary<long, int> { { 2L, 1 }, { 3L, 1 } });
      yield return new TestCaseData(8L, new Dictionary<long, int> { { 2L, 3 } });
      yield return new TestCaseData(9L, new Dictionary<long, int> { { 3L, 2 } });
      yield return new TestCaseData(36L, new Dictionary<long, int> { {2L, 2}, { 3L, 2 } });
      yield return new TestCaseData(72L, new Dictionary<long, int> { {2L, 3}, { 3L, 2 } });
    }
    
    [TestCaseSource(nameof(FactorWithDistinctCountCases))]
    public void FactorWithDistinctCount_ReturnsCorrectResults(long input, Dictionary<long, int> expected)
    {
      var results = Tools.FactorWithDistinctCounts(input);
      Assert.That(results, Is.EqualTo(expected));
    }
    
    
    [TestCase(1, false)]
    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(4, false)]
    [TestCase(5, true)]
    [TestCase(6, false)]
    [TestCase(7, true)]
    [TestCase(8, false)]
    [TestCase(9, false)]
    [TestCase(10, false)]
    [TestCase(11, true)]
    [TestCase(13, true)]
    [TestCase(15, false)]
    [TestCase(17, true)]
    [TestCase(19, true)]
    [TestCase(21, false)]
    [TestCase(23, true)]
    [TestCase(25, false)]
    [TestCase(27, false)]
    [TestCase(29, true)]
    [TestCase(30, false)]
    [TestCase(31, true)]
    [TestCase(33, false)]
    [TestCase(35, false)]
    [TestCase(37, true)]
    [TestCase(49, false)]
    [TestCase(101, true)]
    [TestCase(111, false)]
    [TestCase(121, false)]
    public void IsPrime_ReturnsCorrectResult(int input, bool expected)
    {
      var result = Tools.IsPrime(input);
      Assert.That(result, Is.EqualTo(expected));
    }
    
    
    [TestCase(-1, 0)]
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(9, 9)]
    [TestCase(11, 121)]
    [TestCase(99, 9009)]
    public void GetLargestPalindromeProduct_ReturnsCorrectResult(int input, int expected)
    {
      var results = Tools.GetLargestPalindromeProduct(input);
      Assert.That(results, Is.EqualTo(expected));
    }
    
    
    [TestCase(-1, false)]
    [TestCase(0, true)]
    [TestCase(1, true)]
    [TestCase(9, true)]
    [TestCase(10, false)]
    [TestCase(11, true)]
    [TestCase(100, false)]
    [TestCase(101, true)]
    [TestCase(111, true)]
    [TestCase(112, false)]
    [TestCase(121, true)]
    [TestCase(1231, false)]
    [TestCase(12321, true)]
    public void IsPalindrome_ReturnsCorrectResult(int input, bool expected)
    {
      var results = Tools.IsPalindrome(input);
      Assert.That(results, Is.EqualTo(expected));
    }    
    
  }
}
