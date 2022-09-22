namespace Application.Domain
{
    public abstract class LoanClassification
    {
        public abstract double CalculateInterestAmount(double principalAmount, int months);
    }
}
