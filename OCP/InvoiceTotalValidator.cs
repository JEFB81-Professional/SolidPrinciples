namespace SolidPrinciples.OCP
{
    public class InvoiceTotalValidator : Validator
    {
        public override bool IsValid(Invoice invoice)
        {
            if (invoice.CalculateTotal() < 0)
            {
                return false;
            }
            return true;
        }
    }
}