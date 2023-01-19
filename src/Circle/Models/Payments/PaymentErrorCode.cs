﻿namespace MyJetWallet.Circle.Models.Payments
{
    public enum PaymentErrorCode
    {
        PaymentFailed,
        PaymentFraudDetected,
        PaymentDenied,
        PaymentNotSupportedByIssuer,
        PaymentNotFunded,
        PaymentUnprocessable,
        PaymentStoppedByIssuer,
        PaymentCanceled,
        PaymentReturned,
        PaymentFailedBalanceCheck,
        CardFailed,
        CardInvalid,
        CardAddressMismatch,
        CardZipMismatch,
        CardCvvInvalid,
        CardExpired,
        CardLimitViolated,
        CardNotHonored,
        CardCvvRequired,
        //CreditCardNotAllowed,
        CardAccountIneligible,
        //CardNetworkUnsupported,
        //ChannelInvalid,
        UnauthorizedTransaction,
        BankAccountIneligible,
        BankTransactionError,
        InvalidAccountNumber,
        InvalidWireRtn,
        InvalidAchRtn,
        RefIdInvalid,
        AccountNameMismatch,
        AccountNumberMismatch,
        AccountIneligible,
        WalletAddressMismatch,
        CustomerNameMismatch,
        InstitutionNameMismatch,

        VerificationFailed,
        VerificationFraudDetected,
        //VerificationDenied,
        VerificationNotSupportedByIssuer,
        VerificationStoppedByIssuer,

        ThreeDSecureNotSupported,
        ThreeDSecureRequired,
        ThreeDSecureFailure,
        ThreeDSecureActionExpired,
        ThreeDSecureInvalidRequest,
        CardRestricted
    }
}