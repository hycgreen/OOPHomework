using System;

namespace BMICalculator
{
    public class MaleBMICalculator : BMICalculator
    {
        public override void Calculate()
        {
            var bmi = this.BMI();

            this.BMIInfomation.Recommendation = "適中";

            if (bmi < 20.0)
            {
                this.BMIInfomation.Recommendation = "太瘦";
            }

            if (bmi > 25.0)
            {
                this.BMIInfomation.Recommendation = "太胖";
            }
        }
    }
}