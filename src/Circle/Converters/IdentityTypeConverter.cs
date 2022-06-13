using System.Collections.Generic;
using MyJetWallet.Circle.Base;
using MyJetWallet.Circle.Models.Transfers;

namespace MyJetWallet.Circle.Converters
{
    public class IdentityTypeConverter : BaseConverter<IdentityType>
    {
        public IdentityTypeConverter() : this(true)
        {
        }

        public IdentityTypeConverter(bool quotes) : base(quotes)
        {
        }

        protected override List<KeyValuePair<IdentityType, string>> Mapping => new()
        {
            new KeyValuePair<IdentityType, string>(IdentityType.Business, "business"),
            new KeyValuePair<IdentityType, string>(IdentityType.Individual, "individual"),

        };
    }
}