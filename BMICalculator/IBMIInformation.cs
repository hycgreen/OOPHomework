namespace BMICalculator
{
    public interface IBMIInformation
    {
        Gender Gender { get; set; }

        double Height { get; set; }

        double Wight { get; set; }
    }
}