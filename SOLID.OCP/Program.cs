using SOLID.OCP;

Invoice FInvoice = new FinalInvoice();
Invoice PInvoice = new ProposedInvoice();
Invoice RInvoice = new RecurringInvoice();

double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

Console.ReadKey();