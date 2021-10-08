using System.Collections.Generic;
using MyJetWallet.Circle.Base;
using MyJetWallet.Circle.Models.Payments;

namespace MyJetWallet.Circle.Converters
{
    public class PaymentStatusConverter : BaseConverter<PaymentStatus>
    {
        public PaymentStatusConverter() : this(true)
        {
        }

        public PaymentStatusConverter(bool quotes) : base(quotes)
        {
        }

        protected override List<KeyValuePair<PaymentStatus, string>> Mapping => new()
        {
            new KeyValuePair<PaymentStatus, string>(PaymentStatus.Pending, "pending"),
            new KeyValuePair<PaymentStatus, string>(PaymentStatus.Confirmed, "confirmed"),
            new KeyValuePair<PaymentStatus, string>(PaymentStatus.Paid, "paid"),
            new KeyValuePair<PaymentStatus, string>(PaymentStatus.Failed, "failed"),
            new KeyValuePair<PaymentStatus, string>(PaymentStatus.ActionRequired, "action_required")
        };
    }
}