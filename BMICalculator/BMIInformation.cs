using System;

namespace BMICalculator
{
    public class BMIInformation : IBMIInformation
    {
        public Gender Gender
        {
            get; set;
        }

        public double Height
        {
            get; set;
        }

        public double Wight
        {
            get; set;
        }

        private string recommendation;

        public string Recommendation
        {
            get { return recommendation; }
            private set { recommendation = value; }
        }
    }
}