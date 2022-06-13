using System.Collections.Generic;
using MyJetWallet.Circle.Base;
using MyJetWallet.Circle.Models.Payments;
using MyJetWallet.Circle.Models.Transfers;

namespace MyJetWallet.Circle.Converters
{
    public class TransferErrorCodeConverter : BaseConverter<TransferErrorCode>
    {
        public TransferErrorCodeConverter() : this(true)
        {
        }

        public TransferErrorCodeConverter(bool quotes) : base(quotes)
        {
        }

        protected override List<KeyValuePair<TransferErrorCode, string>> Mapping => new()
        {
            new KeyValuePair<TransferErrorCode, string>(TransferErrorCode.BlockchainError, "blockchain_error"),
            new KeyValuePair<TransferErrorCode, string>(TransferErrorCode.TransferDenied, "transfer_denied"),
            new KeyValuePair<TransferErrorCode, string>(TransferErrorCode.TransferFailed, "transfer_failed"),
            new KeyValuePair<TransferErrorCode, string>(TransferErrorCode.InsufficientFunds, "insufficient_funds"),
        };
    }
}