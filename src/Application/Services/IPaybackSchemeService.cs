using Application.Domain;

namespace Application.Services
{
    public interface IPaybackSchemeService
    {
        public IEnumerable<Payback> GetHousingLoanPaybacks(double principalAmount, DateTime startDate, DateTime endDate);
        public IEnumerable<Payback> GetHousingLoanPaybacks(double principalAmount, int months);
    }
}
