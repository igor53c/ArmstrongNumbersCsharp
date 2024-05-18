using Xunit;

namespace ArmstrongNumbers.Tests
{
    public class ArmstrongNumbersTests
    {
        [Fact]
        public void TestSingleDigitNumbers()
        {
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(0));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(1));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(2));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(3));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(4));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(5));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(6));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(7));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(8));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(9));
        }

        [Fact]
        public void TestDoubleDigitNumbers()
        {
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(10));
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(11));
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(99));
        }

        [Fact]
        public void TestKnownArmstrongNumbers()
        {
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(153));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(370));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(371));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(407));
            Assert.True(ArmstrongNumbers.IsArmstrongNumber(9474));
        }

        [Fact]
        public void TestKnownNonArmstrongNumbers()
        {
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(9475));
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(100));
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(123));
            Assert.False(ArmstrongNumbers.IsArmstrongNumber(400));
        }
    }
}
