using SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidPrinciples.OpenClosedPrinciple
{
    public class InvoiceTaxRateValidator : Validator
    {
        public override bool IsValid(Invoice invoice)
        {
            if (invoice.TaxRate < 0)
            {
                return false;
            }
            return true;
        }
    }   
}