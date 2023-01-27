using System;
using System.Collections.Generic;
using FizzBuzz;
using FluentAssertions;
using Xunit;

namespace FizzBuzzTests
{
    public class Tests
    {
        [Fact]
        public void TestFizzBuzz()
        {
            var expectedStrings = new List<string>() { "Fizz", "4" };
            var result = FizzBuzzClass.ToStringsFizzBuzz(new List<int>() { 3, 4});
            result.Should().BeEquivalentTo(expectedStrings);
        }
    }
}