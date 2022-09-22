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

            var result = housingLoan.CalculateInterestAmount(1000, 12);

            Assert.Equal(120, result);
        }
    }
}
