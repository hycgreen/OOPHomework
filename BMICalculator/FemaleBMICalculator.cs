using System;

namespace BMICalculator
{
    public class FemaleBMICalculator : BMICalculator
    {
        public override void Calculate()
        {
            var bmi = this.BMI();
            this.BMIInfomation.Recommendation = "適中";

            if (bmi < 18.0)
            {
                this.BMIInfomation.Recommendation = "太瘦";
            }

            if (bmi > 22.0)
            {
                this.BMIInfomation.Recommendation = "太胖";
            }
        }
    }
}