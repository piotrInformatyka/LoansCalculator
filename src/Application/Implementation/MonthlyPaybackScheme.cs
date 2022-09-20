using Application.Domain;

namespace Application.Implementation
{
    public class MonthlyPaybackScheme : PaybackScheme
    {
        public override IEnumerable<Payback> GetPaybacks(double totalAmount, DateTime startDate, DateTime endTime)
        {
            var totalMonths = ((endTime.Year - startDate.Year) * 12) + endTime.Month - startDate.Month;

            var singleRate = Math.Floor(totalAmount / totalMonths);
            var lastRate = singleRate + totalAmount % totalMonths;

            return Enumerable.Range(1, totalMonths).Select(month => new Payback()
            {
                PaybackDay = startDate.AddMonths(month),
                Amount = month != totalMonths ? singleRate : lastRate
            });
        }
    }
}
