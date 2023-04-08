using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests
{
    public class PrimeFactorsUnitTest
    {
        [Fact]
        public void PrimeFactorsTest1()
        {
            //arrange
            int input = 1;
            string expected = "Input must be > 1";

            //act
            string actual = PrimeFactorsLib.PrimeFactors(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsTest0()
        {
            //arrange
            int input = 0;
            string expected = "Input must be > 1";

            //act
            string actual = PrimeFactorsLib.PrimeFactors(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsTest387()
        {
            //arrange
            int input = 387;
            string expected = "3 x 3 x 43";

            //act
            string actual = PrimeFactorsLib.PrimeFactors(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsTest1000()
        {
            //arrange
            int input = 1000;
            string expected = "2 x 2 x 2 x 5 x 5 x 5";

            //act
            string actual = PrimeFactorsLib.PrimeFactors(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsTest7()
        {
            //arrange
            int input = 7;
            string expected = "7";

            //act
            string actual = PrimeFactorsLib.PrimeFactors(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsTest50()
        {
            //arrange
            int input = 50;
            string expected = "2 x 5 x 5";

            //act
            string actual = PrimeFactorsLib.PrimeFactors(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}