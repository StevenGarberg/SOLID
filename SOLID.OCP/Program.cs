using SOLID.OCP;

var FInvoice = new Invoice(InvoiceType.FinalInvoice);
var PInvoice = new Invoice(InvoiceType.ProposedInvoice);
var RInvoice = new Invoice(InvoiceType.RecurringInvoice);

double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

Console.ReadKey();