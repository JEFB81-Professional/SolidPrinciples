using SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidPrinciples.OpenClosedPrinciple
{
    /// <summary>
    /// The Validator class serves as a base for different types of validators, adhering to the Open/Closed Principle.
    /// It can be extended to create specific validators without modifying existing code.
    /// </summary>
    public abstract class Validator
    {
        public abstract bool IsValid(Invoice invoice);
    }
}