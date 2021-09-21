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
                "verificationFailed"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationFraudDetected,
                "verificationFraudDetected"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationDenied,
                "verificationDenied"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationNotSupportedByIssuer,
                "verificationNotSupportedByIssuer"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.VerificationStoppedByIssuer,
                "verificationStoppedByIssuer"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardFailed, "cardFailed"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardInvalid, "cardInvalid"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardAddressMismatch,
                "cardAddressMismatch"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardZipMismatch, "cardZipMismatch"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardCvvInvalid, "cardCvvInvalid"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardExpired, "cardExpired"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardLimitViolated,
                "cardLimitViolated"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardNotHonored, "cardNotHonored"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardCvvRequired, "cardCvvRequired"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CreditCardNotAllowed,
                "creditCardNotAllowed"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardAccountIneligible,
                "cardAccountIneligible"),
            new KeyValuePair<CardVerificationError, string>(CardVerificationError.CardNetworkUnsupported,
                "cardNetworkUnsupported"),
        };
    }
}