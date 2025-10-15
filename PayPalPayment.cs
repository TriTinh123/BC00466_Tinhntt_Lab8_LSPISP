using System;

namespace LSPISP
{
    public class PayPalPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} via PayPal");
        }
    }
}
