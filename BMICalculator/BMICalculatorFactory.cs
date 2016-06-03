using System;

namespace BMICalculator
{
    public static class BMICalculatorFactory
    {
        public static IBMICalculator GetBMICalculator(BMIInformation info)
        {
            switch (info.Gender)
            {
                case Gender.Male:
                    return new MaleBMICalculator();

                case Gender.Female:
                    return new FemaleBMICalculator();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
