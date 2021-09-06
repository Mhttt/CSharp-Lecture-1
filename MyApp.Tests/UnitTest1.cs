using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void isLeapYear()
        {
            Assert.Equal(true, Program.IsLeapYear(4));
        }

        [Fact]

        public void isLeapYear400() {
            Assert.Equal(true, Program.IsLeapYear(400));
        }

        [Fact]
        public void isNotLeapYear1700() {
            Assert.Equal(false, Program.IsLeapYear(1700));
        }

        [Fact]
        public void isNotLeapYear3() {
            Assert.Equal(false, Program.IsLeapYear(3));
        }
    }
}
