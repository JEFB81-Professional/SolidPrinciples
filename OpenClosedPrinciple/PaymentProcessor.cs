using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciple
{
    public class PaymentProcessor
    {

        public void Process(IPaymentMethod paymentMethod)
        {
            paymentMethod.ProcessPayment();
        }

    }
}