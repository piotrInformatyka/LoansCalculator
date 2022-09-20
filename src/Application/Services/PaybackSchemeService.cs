using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Domain;
using Application.Implementation;

namespace Application.Services
{
    public class PaybackSchemeService : IPaybackSchemeService
    {
        public IEnumerable<Payback> GetHousingLoanPaybacks(double principalAmount, DateTime startDate, DateTime endDate)
        {
            var housingLoan = new PaybackCalculator(new HousingLoan(3.5), new MonthlyPaybackScheme()); //todo: use creational patterns

            return housingLoan.GetPaybacks(principalAmount, startDate, endDate);
        }

        public IEnumerable<Payback> GetHousingLoanPaybacks(double principalAmount, int months)
        {
            var housingLoan = new PaybackCalculator(new HousingLoan(3.5), new MonthlyPaybackScheme()); //todo: use creational patterns
            var actualDate = DateTime.Now;

            return housingLoan.GetPaybacks(principalAmount, actualDate, actualDate.AddMonths(months));
        }
    }
}
