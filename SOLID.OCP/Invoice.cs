namespace SOLID.OCP;

public interface IDiscountable
{
    double GetInvoiceDiscount(double amount);
}

public class Invoice : IDiscountable
{
    public virtual double GetInvoiceDiscount(double amount)
    {
        return amount - 10;
    }
}
    
public class FinalInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 50;
    }
}
public class ProposedInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 40;
    }
}
public class RecurringInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return base.GetInvoiceDiscount(amount) - 30;
    }
}