using System;
using Xunit;
using isogram;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Class1.Convert("")); 
        }

        [Fact]
        public void Test2()
        {
            Assert.True(Class1.Convert("isogram"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(Class1.Convert("eleven"));
        }

        [Fact]
        public void Test4()
        {
            Assert.True(Class1.Convert("subdermatoglyphic"));
        }

        [Fact]
        public void Test6()
        {
            Assert.True(Class1.Convert("thumbscrew-japingly"));
        }

        [Fact]
        public void Test7()
        {
            Assert.True(Class1.Convert("six-year-old"));
        }

        [Fact]
        public void Test8()
        {
            Assert.True(Class1.Convert("abc def"));
        }

    }
}
