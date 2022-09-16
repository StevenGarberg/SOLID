// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ConvertIfStatementToSwitchExpression
// ReSharper disable ConvertIfStatementToSwitchStatement
namespace SOLID.OCP;

public class Invoice
{
    public InvoiceType InvoiceType { get; }
    
    public Invoice(InvoiceType invoiceType)
    {
        InvoiceType = invoiceType;
    }
    
    public double GetInvoiceDiscount(double amount)
    {
        double finalAmount = 0;
        if (InvoiceType == InvoiceType.FinalInvoice)
        {
            finalAmount = amount - 100;
        }
        else if (InvoiceType == InvoiceType.ProposedInvoice)
        {
            finalAmount = amount - 50;
        }
        // No implementation for recurring invoice; returns 0
        return finalAmount;
    }
}

public enum InvoiceType
{
    FinalInvoice,
    ProposedInvoice,
    RecurringInvoice
};