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
            var monthlyScheme = new MonthlyPaybackScheme();
            var startDate = new DateTime(2021, 07, 20);

            var result = monthlyScheme.GetPaybacks(1000, startDate, startDate.AddDays(365));
            var lastRate = result.OrderByDescending(x => x.PaybackDay)?.FirstOrDefault()?.Amount;

            Assert.NotNull(result);
            Assert.Equal(12, result.Count());
            Assert.Equal(87, lastRate);
        }
    }
}
