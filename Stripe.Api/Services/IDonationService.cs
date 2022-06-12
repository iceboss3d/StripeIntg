using Stripe.Api.Models;
using Stripe.Checkout;
using System.Threading.Tasks;

namespace Stripe.Api.Services
{
    public interface IDonationService
    {
        Session CreatePayment(DonationModel paymentDetails);
        Task RetrievePayment(string id);
        Task RetrievePayments();
    }
}
