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
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
