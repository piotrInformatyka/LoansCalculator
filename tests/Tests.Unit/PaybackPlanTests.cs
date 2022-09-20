using Application.Domain;
using Application.Implementation;
using System;
using System.Linq;
using Xunit;

namespace Tests.Unit
{
    public class PaybackPlanTests
    {
        [Fact]
        public void GetPaybacksWithMonthlyHousingLoan_Should_ReturnsCorrectPaybacks()
        {
            var loanClassification = new HousingLoan(12);
            var monthlyScheme = new MonthlyPaybackScheme();
            var paybackPlan = new PaybackCalculator(loanClassification, monthlyScheme);
            var startDate = new DateTime(2021, 07, 20);

            var result = paybackPlan.GetPaybacks(1000, startDate, startDate.AddDays(365));
            var lastRate = result.OrderByDescending(x => x.PaybackDay)?.FirstOrDefault()?.Amount;
            var totalAmount = result.Sum(x => x.Amount);

            Assert.NotNull(result);
            Assert.Equal(12, result.Count());
            Assert.Equal(97, lastRate);
            Assert.Equal(1120, totalAmount);
        }
    }
}
