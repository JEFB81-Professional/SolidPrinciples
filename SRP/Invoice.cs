namespace SolidPrinciples
{
    /// <summary>
    /// the Invoice class adheres to the Single Responsibility Principle by focusing solely on invoice-related operations.
    /// the are two main responsibilities: calculating totals and printing the invoice.
    /// </summary>
    public class Invoice
    {
        public decimal Subtotal { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }

        public decimal CalculateTax()
        {
            return Subtotal * TaxRate / 100;
        }

        // first single responsibility violation
        public decimal CalculateTotal()
        {
            return Subtotal + CalculateTax();
        }

        // second single responsibility violation
        // Remove method and Added method to delegate printing responsibility to Printer class
        // public void PrintInvoice()
        // {
        //     // Logic to print the invoice
        // }
    }

    /// <summary>
    /// The Printer class is responsible for printing invoices, adhering to the Single Responsibility Principle.
    /// </summary>
    public class Printer
    {
        public void PrintInvoice()
        {
            // Logic to print the invoice
        }
    }
}