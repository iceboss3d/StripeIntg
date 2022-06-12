using Stripe.Api.Models;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe.Api.Services
{
    public class DonationService : IDonationService
    {
        public Session CreatePayment(DonationModel paymentDetails)
        {
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Amount = Convert.ToInt64(paymentDetails.Amount) * 100,
                        Name = "Walk out Malaria"
                    }
                },
                Mode = "payment",
                CustomerEmail = paymentDetails.Email,
                
            };
            var service = new SessionService();
            Session session = service.Create(options);
            session.Currency = paymentDetails.Currency;
            return session;
        }

        public Task RetrievePayment(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task RetrievePayments()
        {
            throw new System.NotImplementedException();
        }
    }
}
