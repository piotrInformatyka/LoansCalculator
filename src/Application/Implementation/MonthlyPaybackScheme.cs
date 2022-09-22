using Application.Domain;

namespace Application.Implementation
{
    public class MonthlyPaybackScheme : PaybackScheme
    {
        protected override LoanClassification LoanClassification { get; }
        public MonthlyPaybackScheme(LoanClassification loanClassification)
        {
            LoanClassification = loanClassification;
        }

        public override IEnumerable<Payback> GetPaybacks(double totalAmount, int months)
        {
            var singleRate = totalAmount / months;
            var actualDay = DateTime.Now;

            for(var month = 1; month <= months; month++)
            {
                yield return new Payback
                {
                    PaybackDay = actualDay.AddMonths(month),
                    Interest = LoanClassification.CalculateInterestAmount(totalAmount, 1),
                    Amount = singleRate
                };
                totalAmount -= singleRate;
            }
        }
    }
}
