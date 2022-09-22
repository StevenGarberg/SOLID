using SOLID.OCP;

IDiscountable FInvoice = new FinalInvoice();
IDiscountable PInvoice = new ProposedInvoice();
IDiscountable RInvoice = new RecurringInvoice();

double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

Console.ReadKey();