using SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidPrinciples.OpenClosedPrinciple
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