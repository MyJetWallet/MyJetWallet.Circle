namespace MyJetWallet.Circle.Models.Payouts
{
    public enum PayoutErrorCode
    {
        InsufficientFunds,
        TransactionDenied, TransactionFailed, TransactionReturned, BankTransactionError, FiatAccountLimitExceeded, InvalidBankAccountNumber, InvalidAchRtn, InvalidWireRtn, VendorInactive
    }
}