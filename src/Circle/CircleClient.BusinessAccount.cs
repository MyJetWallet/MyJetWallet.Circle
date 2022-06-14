using System.Threading;
using System.Threading.Tasks;
using MyJetWallet.Circle.Models;
using MyJetWallet.Circle.Models.BusinessAccounts;
using MyJetWallet.Circle.Models.Payments;

namespace MyJetWallet.Circle
{
    public partial class CircleClient
    {
        #region BusinessAccount

       
        public async Task<WebCallResult<ConfigurationInfo>> GetConfigurationInfoAsync(CancellationToken cancellationToken = default)
        {
            return await GetAsync<ConfigurationInfo>($"{EndpointUrl}/configuration", cancellationToken);
        }

        public async Task<WebCallResult<BalanceInfo>> GetBalanceAsync(CancellationToken cancellationToken = default)
        {
            return await GetAsync<BalanceInfo>($"{EndpointUrl}/businessAccount/balances", cancellationToken);
        }

        public async Task<WebCallResult<TransferInfo>> CreateBusinessTransferAsync(string idempotencyKey, string destinationAddressId, string amount, string currency, CancellationToken cancellationToken = default)
        {
            var request = new CreateTransferRequest()
            {
                Amount = new Models.Payouts.CircleAmount
                {
                    Amount = amount,
                    Currency = currency,
                },
                IdempotencyKey = idempotencyKey,
                Destination = new CreateTransferDestination
                {
                    AddressId = destinationAddressId,
                    Type = "verified_blockchain",
                }
            };
            return await PostAsync<TransferInfo>($"{EndpointUrl}/businessAccount/transfers", cancellationToken);
        }

        public async Task<WebCallResult<TransferInfo[]>> GetBusinessTransferAsync(string pageAfter, int pageSize, CancellationToken cancellationToken = default)
        {
            var query = string.IsNullOrEmpty(pageAfter) ? "" : $"pageAfter={pageAfter}";
            return await GetAsync<TransferInfo[]>($"{EndpointUrl}/businessAccount/transfers?{query}&pageSize={pageSize}", cancellationToken);
        }

        public async Task<WebCallResult<DepositAddressInfo>> CreateBusinessDepositAddressesAsync(string idempotencyKey, string currency, string chain, CancellationToken cancellationToken = default)
        {
            var request = new CreateDepositAddressRequest
            {
                Chain = chain,
                Currency = currency,
                IdempotencyKey = idempotencyKey
            };
            return await PostAsync<DepositAddressInfo>($"{EndpointUrl}/businessAccount/deposit", request, cancellationToken);
        }

        public async Task<WebCallResult<DepositAddressInfo[]>> GetBusinessDepositAddressesAsync(CancellationToken cancellationToken = default)
        {
            return await GetAsync<DepositAddressInfo[]>($"{EndpointUrl}/businessAccount/deposit", cancellationToken);
        }

        public async Task<WebCallResult<DepositInfo[]>> GetBusinessDepositsAsync(string pageAfter, int pageSize,
            CancellationToken cancellationToken = default)
        {
            var query = string.IsNullOrEmpty(pageAfter) ? "" : $"pageAfter={pageAfter}";
            return await GetAsync<DepositInfo[]>($"{EndpointUrl}/businessAccount/deposits?{query}&pageSize={pageSize}", cancellationToken);
        }
    }

    #endregion
}