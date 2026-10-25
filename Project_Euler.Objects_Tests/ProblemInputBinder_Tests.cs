using System;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using Project_Euler.Objects;

namespace Project_Euler.Objects_Tests
{
  [TestFixture]
  public class ProblemInputBinder_Tests
  {
    public sealed record NumericInput(int Count, long Seed);

    public sealed record FileInput(int Limit, string FilePath);

    public sealed record PositiveLimitInput(
      [property: System.ComponentModel.DataAnnotations.Range(1, int.MaxValue)] int Limit);

    [Test]
    public void BindConvertsValuesToRecordParameterTypes()
    {
      var result = ProblemInputBinder.Bind<NumericInput>("12 34");

      Assert.That(result.Count, Is.EqualTo(12));
      Assert.That(result.Seed, Is.EqualTo(34L));
    }

    [Test]
    public void BindPreservesSpacesAndBackslashesInsideQuotedValue()
    {
      var result = ProblemInputBinder.Bind<FileInput>(
        @"12 ""C:\some file\input.txt""");

      Assert.That(result.Limit, Is.EqualTo(12));
      Assert.That(result.FilePath, Is.EqualTo(@"C:\some file\input.txt"));
    }

    [Test]
    public void BindReportsExpectedInputShapeWhenValueCountIsWrong()
    {
      var exception = Assert.Throws<FormatException>(
        () => ProblemInputBinder.Bind<NumericInput>("12"));

      Assert.That(exception!.Message, Does.Contain("Expected 2 value(s)"));
      Assert.That(exception.Message, Does.Contain("Count"));
      Assert.That(exception.Message, Does.Contain("Seed"));
    }

    [Test]
    public void BindReportsWhichValueCouldNotBeConverted()
    {
      var exception = Assert.Throws<FormatException>(
        () => ProblemInputBinder.Bind<NumericInput>("not-an-int 34"));

      Assert.That(exception!.Message, Does.Contain("input value 1"));
      Assert.That(exception.Message, Does.Contain("Count"));
    }

    [Test]
    public void BindValidatesRecordProperties()
    {
      Assert.Throws<ValidationException>(
        () => ProblemInputBinder.Bind<PositiveLimitInput>("0"));
    }

    [Test]
    public void BindRejectsUnmatchedQuote()
    {
      Assert.Throws<FormatException>(
        () => ProblemInputBinder.Bind<FileInput>(@"12 ""C:\some file\input.txt"));
    }

    [Test]
    public void BindRejectsCharactersImmediatelyAfterQuotedValue()
    {
      Assert.Throws<FormatException>(
        () => ProblemInputBinder.Bind<FileInput>(@"12 ""some path""suffix"));
    }
  }
}
