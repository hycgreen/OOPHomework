using System;

namespace BMICalculator
{
    public static class BMICalculatorFactory
    {
        public static IBMICalculator GetBMICalculator(BMIInformation info)
        {
            IBMICalculator bmiCalculator;
            switch (info.Gender)
            {
                case Gender.Male:
                    bmiCalculator = new MaleBMICalculator();
                    break;

                case Gender.Female:
                    bmiCalculator = new FemaleBMICalculator();
                    break;

                default:
                    throw new NotSupportedException();
            }

            ((BMICalculator) bmiCalculator).BMIInfomation = info;

            return bmiCalculator;
        }
    }
}
