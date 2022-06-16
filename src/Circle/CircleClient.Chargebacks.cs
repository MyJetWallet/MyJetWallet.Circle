using System.Threading;
using System.Threading.Tasks;
using MyJetWallet.Circle.Models;
using MyJetWallet.Circle.Models.ChargeBacks;
using MyJetWallet.Circle.Models.Payments;
using MyJetWallet.Circle.Models.Payouts;
using MyJetWallet.Circle.Models.Wallets;

namespace MyJetWallet.Circle
{
    public partial class CircleClient
    {
        #region Chargebacks

        public async Task<WebCallResult<Chargeback[]>> GetChargebacksAsync(string pageAfter, int pageSize,
            CancellationToken cancellationToken = default)
        {
            var query = string.IsNullOrEmpty(pageAfter) ? "" : $"pageAfter={pageAfter}";
            return await GetAsync<Chargeback[]>($"{EndpointUrl}/chargebacks?{query}&pageSize={pageSize}", cancellationToken);
        }
    }

    #endregion
}