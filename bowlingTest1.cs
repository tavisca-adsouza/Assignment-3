using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //rogram pg = new Program();
            int[,] pairScore = {{4, 5}, {10, 0}, {5, 5}, {3, 4}, {4, 5}, {3, 4}, {1, 7}, {4, 4}, {4, 5}, {9, 0}};

	        var x = 5;
            var y = 2;
	    bool cond = y == 2;
            var expected = 7;
            var actual = x + y + 1;
            Assert.Equal(expected, actual);

            var result = Program.calculateScore(pairScore);

            Assert.Equal(99, result);

        }
    }
}
