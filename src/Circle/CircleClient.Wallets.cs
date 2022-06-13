using System.Threading;
using System.Threading.Tasks;
using MyJetWallet.Circle.Models;
using MyJetWallet.Circle.Models.Payments;
using MyJetWallet.Circle.Models.Payouts;
using MyJetWallet.Circle.Models.Wallets;

namespace MyJetWallet.Circle
{
    public partial class CircleClient
    {
        #region Wallets

        public async Task<WebCallResult<WalletInfo>> CreateWalletAsync(string idempotencyKey, string description, 
            CancellationToken cancellationToken = default)
        {
            var data = new CreateWalletRequest()
            {
                IdempotencyKey = idempotencyKey,
                Description = description,
            };
            return await PostAsync<WalletInfo>($"{EndpointUrl}/wallets", data, cancellationToken);
        }

        public async Task<WebCallResult<WalletInfo>> GetWalletAsync(string id,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<WalletInfo>($"{EndpointUrl}/wallets/{id}", cancellationToken);
        }

        public async Task<WebCallResult<WalletInfo[]>> GetWalletsAsync(string pageAfter, int pageSize,
            CancellationToken cancellationToken = default)
        {
            var query = string.IsNullOrEmpty(pageAfter) ? "" : $"pageAfter={pageAfter}";
            return await GetAsync<WalletInfo[]>($"{EndpointUrl}/wallets?{query}&pageSize={pageSize}", cancellationToken);
        }
    }

    #endregion
}