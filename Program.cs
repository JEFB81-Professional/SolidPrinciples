// See https://aka.ms/new-console-template for more information
using SolidPrinciples;
using SolidPrinciples.OCP;


// Create an invoice instance for validation with object-oriented validators
// solid principles - open/closed principle
Invoice invoice = new()
{
    Subtotal = 100,
    TaxRate = 0.05m // Example values
};

Validator subtotalValidator = new InvoiceSubtotalValidator();
Validator taxRateValidator = new InvoiceTaxRateValidator();
Validator totalValidator = new InvoiceTotalValidator();

bool isSubtotalValid = subtotalValidator.IsValid(invoice);
bool isTaxRateValid = taxRateValidator.IsValid(invoice);
bool isTotalValid = totalValidator.IsValid(invoice);

Console.WriteLine($"Subtotal is valid: {isSubtotalValid}");
Console.WriteLine($"Tax rate is valid: {isTaxRateValid}");
Console.WriteLine($"Total is valid: {isTotalValid}");