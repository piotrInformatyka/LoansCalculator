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
        public IEnumerable<Payback> GetHousingLoanPaybacks(double principalAmount, int months)
        {
            var housingLoan = new MonthlyPaybackScheme(new HousingLoan(3.5));
            return housingLoan.GetPaybacks(principalAmount, months);
        }
    }
}
