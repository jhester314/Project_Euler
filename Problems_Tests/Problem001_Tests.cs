using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problems;
using Project_Euler.Objects;

namespace Problems_Tests
{
    [TestFixture]
    public class Problem001_Tests
    {
        private Problem001 _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Problem001();
        }

        [TestCase(5, 3)]
        [TestCase(6, 8)]
        [TestCase(10, 23)]
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
