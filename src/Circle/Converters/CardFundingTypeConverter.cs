using System.Collections.Generic;
using MyJetWallet.Circle.Base;
using MyJetWallet.Circle.Models.Cards;

namespace MyJetWallet.Circle.Converters
{
    public class CardFundingTypeConverter : BaseConverter<CardFundingType>
    {
        public CardFundingTypeConverter() : this(true)
        {
        }

        public CardFundingTypeConverter(bool quotes) : base(quotes)
        {
        }

        protected override List<KeyValuePair<CardFundingType, string>> Mapping => new()
        {
            new KeyValuePair<CardFundingType, string>(CardFundingType.Credit, "credit"),
            new KeyValuePair<CardFundingType, string>(CardFundingType.Debit, "debit"),
            new KeyValuePair<CardFundingType, string>(CardFundingType.Prepaid, "prepaid"),
            new KeyValuePair<CardFundingType, string>(CardFundingType.Unknown, "unknown"),
        };
    }
}