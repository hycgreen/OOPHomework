﻿using System;

namespace BMICalculator
{
    public class MaleBMICalculator : BMICalculator
    {
        public override void Calculate()
        {
            var bmi = this.BMI();

            if (bmi < 20.0)
            {
                this.BMIInfomation.Recommendation = "太瘦";
            }
        }
    }
}