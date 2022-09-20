namespace Application.Domain
{
    public abstract class LoanClassification
    {
        public abstract double CalculateInterestAmount(double principalAmount, TimeSpan loanTime);
    }
}
