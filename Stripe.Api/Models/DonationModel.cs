namespace Stripe.Api.Models
{
    public class DonationModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "USD";
    }
}
