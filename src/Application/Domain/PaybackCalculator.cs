namespace Application.Domain
{
    public class PaybackCalculator
    {
        private LoanClassification LoanClassification { get; }
        private PaybackScheme PaybackScheme { get; }
        public PaybackCalculator(LoanClassification loanClassification, PaybackScheme paybackScheme)
        {
            LoanClassification = loanClassification;
            PaybackScheme = paybackScheme;
        }
        public IEnumerable<Payback> GetPaybacks(double principalAmount, DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new Exception("startDate > endTime");

            var totalTime = endDate - startDate;

            var totalAmount = LoanClassification.CalculateInterestAmount(principalAmount, totalTime);
            return PaybackScheme.GetPaybacks(totalAmount, startDate, endDate);
        }
    }
}
