namespace SolidPrinciples.OCP
{
    public class InvoiceSubtotalValidator : Validator
    {
        public override bool IsValid(Invoice invoice)
        {
            if (invoice.Subtotal < 0)
            {
                return false;
            }
            return true;
        }
    }
}