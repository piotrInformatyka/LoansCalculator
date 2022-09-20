using Application.Commands;
using Application.Domain;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly IPaybackSchemeService _paybackSchemeService;

        public LoansController(IPaybackSchemeService paybackSchemeService)
        {
            _paybackSchemeService = paybackSchemeService;
        }

        [HttpPost("loans")]
        public IEnumerable<Payback> CalculateHousingLoan(GetHousingLoanWithMonths command)
            => _paybackSchemeService.GetHousingLoanPaybacks(command.PrincipleAmount, command.Months);
        
        [HttpPost("loans/anyDate")]
        public IEnumerable<Payback> CalculateHousingLoanWithAnyDates(GetHousingLoanWithDates command)
            => _paybackSchemeService.GetHousingLoanPaybacks(command.PrincipleAmount, command.StartDate, command.EndDate);


    }
}
