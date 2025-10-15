namespace LSPISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod paymentMethod = new PayPalPayment();
            ILogger logger = new FileLogger();
            INotifier notifier = new EmailNotifier();

            PaymentService paymentService = new PaymentService(paymentMethod, logger, notifier);
            paymentService.ProcessPayment(100.00m);
        }
    }
}
