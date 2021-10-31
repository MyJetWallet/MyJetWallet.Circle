namespace MyJetWallet.Circle.Models.Payments
{
    public enum PaymentStatus
    {
        Pending,
        Confirmed,
        Complete,
        Paid,
        Failed,
        ActionRequired
    }
}