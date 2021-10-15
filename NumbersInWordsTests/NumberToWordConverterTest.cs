using NumbersInWords;
using NUnit.Framework;

namespace NumbersInWordsTests
{
    public class NumberToWordConverterTest
    {
        private readonly NumberToWordConverter converter = new NumberToWordConverter();

        [Test]
        public void ConvertZero() {
            var result = converter.Convert(0);
            Assert.AreEqual("zero", result);
        }

        [Test]
        public void ConvertOneDecimal() {
            var result = converter.Convert(4);
            Assert.AreEqual("four", result);
        }

        [Test]
        public void ConvertTwoDecimal() {
            var result = converter.Convert(12);
            Assert.AreEqual("twelve", result);
        }

        [Test]
        public void ConvertThreeDecimals() {
            var result = converter.Convert(321);
            Assert.AreEqual("three hundred twenty one", result);
        }

        [Test]
        public void ConvertFourDecimals() {
            var result = converter.Convert(1235);
            Assert.AreEqual("one thousand two hundred thirty five", result);
        }

        [Test]
        public void ConvertFiveDecimals() {
            var result = converter.Convert(43839);
            Assert.AreEqual("forty three thousand eight hundred thirty nine", result);
        }

        [Test]
        public void ConvertNegativeValue() {
            var result = converter.Convert(-87);
            Assert.AreEqual("negative eighty seven", result);
        }
    }
}