using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Cards
{
    [DataContract]
    public enum CardVerificationError
    {
        VerificationFailed,
        VerificationFraudDetected,
        VerificationDenied,
        VerificationNotSupportedByIssuer,
        VerificationStoppedByIssuer,
        CardFailed,
        CardInvalid,
        CardAddressMismatch,
        CardZipMismatch,
        CardCvvInvalid,
        CardExpired,
        CardLimitViolated,
        CardNotHonored,
        CardCvvRequired,
        CreditCardNotAllowed,
        CardAccountIneligible,
        CardNetworkUnsupported
    }
}