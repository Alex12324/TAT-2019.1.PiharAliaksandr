using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2;
using System;

namespace DEV_2Tests
{
    [TestClass]
    public class CommonTests
    {
        /// <summary>
        /// Positive test for a correct translation.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("молоко+","малако")]
        [DataRow("ёлка", "йолка")]
        [DataRow("ме+сто", "м'эста")]
        [DataRow("тря+пка", "тр'апка")]
        [DataRow("вью+га", "в’йуга")]
        [DataRow("моё", "майо")]
        [DataRow("сде+лать", "зд’элат’")]
        [DataRow("зуб", "зуп")]
        public void CommonTest(string input,string expected)
        {
            var expectedString = new StringBuilder(expected);
            var receivedString = new PhoneticConverter(input);
            var actualString = receivedString.Converter();       
            Assert.AreEqual(expectedString.ToString(),actualString.ToString());
        }

        /// <summary>
        /// Negative test for empty input.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "No word was entered.")]
        public void EnteredWordSet_EmptyInput_ThrowException()
        {
            var input = new PhoneticConverter(String.Empty);
        }

        /// <summary>
        /// Negative test for check stress in the beginning of the word.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "The stress cannot be the first character. ")]
        public void EnteredWordSet_NoStressSign_ThrowException()
        {
            var transctiber = new PhoneticConverter("+молоко");
        }

        /// <summary>
        /// Negative test for check stress in the word.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "No stress in the word.")]
        public void EnteredWordSet_NoStressInWord_ThrowException()
        {
            var transctiber = new PhoneticConverter("молоко");
        }

        /// <summary>
        /// Negative test for check stress in the word after consonant.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "The stress after the consonant.")]
        public void EnteredWordSet_StressAfterTheConsonant_ThrowException()
        {
            var transctiber = new PhoneticConverter("м+олоко");
        }
    }
}
