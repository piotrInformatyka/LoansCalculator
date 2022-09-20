using Application.Implementation;
using System;
using Xunit;

namespace Tests.Unit
{
    public class HousingLoanTests
    {
        [Fact]
        public void CalculateAmount_Should_ReturnsResultWithLoanPrinciple()
        {
            var housingLoan = new HousingLoan(12);

            var result = housingLoan.CalculateInterestAmount(1000, new TimeSpan(365, 0, 0, 0, 0));

            Assert.Equal(1120, result);
        }
    }
}
