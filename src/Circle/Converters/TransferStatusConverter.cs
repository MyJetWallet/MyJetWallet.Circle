using System.Collections.Generic;
using MyJetWallet.Circle.Base;
using MyJetWallet.Circle.Models.Cards;
using MyJetWallet.Circle.Models.Transfers;

namespace MyJetWallet.Circle.Converters
{
    public class TransferStatusConverter : BaseConverter<TransferStatus>
    {
        public TransferStatusConverter() : this(true)
        {
        }

        public TransferStatusConverter(bool quotes) : base(quotes)
        {
        }

        protected override List<KeyValuePair<TransferStatus, string>> Mapping => new()
        {
            new KeyValuePair<TransferStatus, string>(TransferStatus.Pending, "pending"),
            new KeyValuePair<TransferStatus, string>(TransferStatus.Complete, "complete"),
            new KeyValuePair<TransferStatus, string>(TransferStatus.Failed, "failed"),
        };
    }
}