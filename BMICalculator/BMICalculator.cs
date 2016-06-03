using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public abstract class BMICalculator : IBMICalculator
    {
        public BMIInformation BMIInfomation { get; set; }

        public double BMI()
        {
            return this.BMIInfomation.Wight / Math.Pow(this.BMIInfomation.Height, 2);
        }

        public abstract void Calculate();
    }
}
