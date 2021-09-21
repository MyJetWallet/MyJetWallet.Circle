using System.Runtime.Serialization;

namespace MyJetWallet.Circle.Models.Cards
{
    [DataContract]
    public enum CardFundingType
    {
        Credit,
        Debit,
        Prepaid,
        Unknown
    }
}