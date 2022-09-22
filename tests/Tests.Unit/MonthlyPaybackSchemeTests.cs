using Application.Implementation;
using System;
using System.Linq;
using Xunit;

namespace Tests.Unit
{

    public class MonthlyPaybackSchemeTests
    {
        [Fact]
        public void GetPaybacks_Should_ReturnsResultWithMontlyScheme()
        {
            var monthlyScheme = new MonthlyPaybackScheme(new HousingLoan(12));

            var result = monthlyScheme.GetPaybacks(1000, 3);
            var lastRate = result.OrderByDescending(x => x.PaybackDay).FirstOrDefault();

            Assert.NotNull(result);
            Assert.Equal(3, result.Count());
            Assert.Equal(3.33, Math.Round(lastRate.Interest, 2));
            Assert.Equal(333.33, Math.Round(lastRate.Amount, 2));
        }
    }
}
