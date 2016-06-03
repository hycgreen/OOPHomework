using System;

namespace BMICalculator
{
    public class FemaleBMICalculator : BMICalculator
    {
        public override void Calculate()
        {
            var bmi = this.BMI();

            if (bmi < 18.0)
            {
                this.BMIInfomation.Recommendation = "太瘦";
            }
        }
    }
}