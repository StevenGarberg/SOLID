using SOLID.OCP;

var FInvoice = new Invoice();
var PInvoice = new Invoice();
var RInvoice = new Invoice();

double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000, InvoiceType.FinalInvoice);
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000, InvoiceType.ProposedInvoice);
double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000, InvoiceType.RecurringInvoice);

Console.ReadKey();