using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;

namespace BMICalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Man_BMI_Less_Then_20_ResultString_Should_Be_TooThin()
        {
            //arrange
            BMIInformation info = new BMIInformation();
            info.Gender = Gender.Male;
            info.Height = 1.75;
            info.Wight = 60;

            IBMICalculator target = BMICalculatorFactory.GetBMICalculator(info);

            //act
            target.Calculate();

            string actual = info.Recommendation;
            string expected = "太瘦";

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Man_BMI_More_Then_25_ResultString_Should_Be_TooFat()
        {
            //arrange
            BMIInformation info = new BMIInformation();
            info.Gender = Gender.Male;
            info.Height = 1.75;
            info.Wight = 80;

            IBMICalculator target = BMICalculatorFactory.GetBMICalculator(info);

            //act
            target.Calculate();

            string actual = info.Recommendation;
            string expected = "太胖";

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Man_BMI_Between_20_And_25_ResultString_Should_Be_Normal()
        {
            //arrange
            BMIInformation info = new BMIInformation();
            info.Gender = Gender.Male;
            info.Height = 1.75;
            info.Wight = 70;

            IBMICalculator target = BMICalculatorFactory.GetBMICalculator(info);

            //act
            target.Calculate();

            string actual = info.Recommendation;
            string expected = "適中";

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Woman_BMI_Less_Then_20_ResultString_Should_Be_TooThin()
        {
            //arrange
            BMIInformation info = new BMIInformation();
            info.Gender = Gender.Female;
            info.Height = 1.6;
            info.Wight = 45;

            IBMICalculator target = BMICalculatorFactory.GetBMICalculator(info);

            //act
            target.Calculate();

            string actual = info.Recommendation;
            string expected = "太瘦";

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Woman_BMI_Less_Then_20_ResultString_Should_Be_TooFat()
        {
            //arrange
            BMIInformation info = new BMIInformation();
            info.Gender = Gender.Female;
            info.Height = 1.6;
            info.Wight = 60;

            IBMICalculator target = BMICalculatorFactory.GetBMICalculator(info);

            //act
            target.Calculate();

            string actual = info.Recommendation;
            string expected = "太胖";

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
