using System.Collections.Generic;
using MyJetWallet.Circle.Base;
using MyJetWallet.Circle.Models.Cards;

namespace MyJetWallet.Circle.Converters
{
    public class CardVerificationErrorConverter : BaseConverter<CardVerificationError>
    {
        public CardVerificationErrorConverter() : this(true)
        {
        }

        public CardVerificationErrorConverter(bool quotes) : base(quotes)
        {
        }

        protected override List<KeyValuePair<CardVerificationError, string>> Mapping => new()
        {
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationFailed,
                "verification_failed"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationFraudDetected,
                "verification_fraud_detected"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationDenied,
                "verification_denied"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationNotSupportedByIssuer,
                "verification_not_supported_by_issuer"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationStoppedByIssuer,
                "verification_stopped_by_issuer"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardFailed, "card_failed"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardInvalid, "card_invalid"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardAddressMismatch,
                "card_address_mismatch"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardZipMismatch, "card_zip_mismatch"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardCvvInvalid, "card_cvv_invalid"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardExpired, "card_expired"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardLimitViolated,
                "card_limit_violated"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardNotHonored, "card_not_honored"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardCvvRequired, "card_cvv_required"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CreditCardNotAllowed,
                "credit_card_not_allowed"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardAccountIneligible,
                "card_account_ineligible"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardNetworkUnsupported,
                "card_network_unsupported"),
        };
    }
}