namespace Application.Domain
{
    public abstract class PaybackScheme
    {
        public abstract IEnumerable<Payback> GetPaybacks(double totalAmount, DateTime startDate, DateTime endTime);
    }
}
