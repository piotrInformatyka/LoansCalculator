using Application.Domain;

namespace Application.Implementation
{
    public class HousingLoan : LoanClassification
    {
        private readonly double _interestRate;
        private double InterestRate => _interestRate / 100;

        private const double SingleMonthFactor = 1.00 / 12;

        public HousingLoan(double interestRate)
        {
            _interestRate = interestRate;
        }
        public override double CalculateInterestAmount(double principalAmount, int months) 
            => principalAmount * months * InterestRate * SingleMonthFactor;
    }
}
