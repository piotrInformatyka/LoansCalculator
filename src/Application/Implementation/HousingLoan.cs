using Application.Domain;

namespace Application.Implementation
{
    public class HousingLoan : LoanClassification
    {
        private readonly double _interestRate;
        private double InterestRate => _interestRate / 100;

        private const double SingleDayFactor = 1.00 / 365;

        public HousingLoan(double interestRate)
        {
            _interestRate = interestRate;
        }
        public override double CalculateInterestAmount(double principalAmount, TimeSpan loanTime) 
            => principalAmount + principalAmount * loanTime.Days * InterestRate * SingleDayFactor;
    }
}
