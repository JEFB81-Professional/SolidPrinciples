using System.Linq;

namespace SolidPrinciples.OCP
{
    /// <summary>
    /// The InvoiveValidator class adheres to the Open/Closed Principle by being open for extension but closed for modification.
    /// It provides a method to validate invoices without altering existing invoice functionality.
    /// </summary>
    public class InvoiveValidator
    {
        /// <summary>
        /// Validates the given invoice. issue with this approach is that every time a new validation rule is needed,
        /// the IsValid method must be modified, which violates the Open/Closed Principle.
        /// </summary>
        // public static bool IsValid(Invoice invoice)
        // {
        //     // Basic validation logic (example: check if subtotal and tax rate are non-negative)
        //     if (invoice.Subtotal < 0 || invoice.TaxRate < 0)
        //     {
        //         return false;
        //     }
        //     return true;
        // }



        ///// <summary>
        /// Validates the given invoice using a list of validators. This approach adheres to the Open/Closed Principle
        /// by allowing new validation rules to be added without modifying existing code.
        /// </summary>
        private readonly List<Validator> _validators;
        public InvoiveValidator(List<Validator> validators)
        {
            _validators = validators;
        }

        public bool Validate(Invoice invoice)
        {
            return _validators.All(v => v.IsValid(invoice));
        }
    }
}