namespace Application.Domain
{
    public abstract class PaybackScheme
    {
        protected abstract LoanClassification LoanClassification { get; }
        public abstract IEnumerable<Payback> GetPaybacks(double totalAmount, int months);
    }
}
