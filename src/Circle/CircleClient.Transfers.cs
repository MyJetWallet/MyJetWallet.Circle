using System.Threading;
using System.Threading.Tasks;
using MyJetWallet.Circle.Models;
using MyJetWallet.Circle.Models.Transfers;

namespace MyJetWallet.Circle
{
    public partial class CircleClient
    {
        #region Transfers

        public async Task<WebCallResult<TransferInfo>> CreateTransferV2Async(string idempotencyKey, string amount, string currency, string sourceId,  string address , string addressTag, string destinationChain, CancellationToken cancellationToken = default)
        {
            var data = new CreateTransferRequest()
            {
                IdempotencyKey = idempotencyKey,
                Amount = new Models.Payouts.CircleAmount
                {
                    Amount = amount,
                    Currency = currency,
                },
                Destination = new TransferDestination
                {
                    Address = address,
                    AddressTag = addressTag,
                    Chain = destinationChain,
                    Type = "blockchain"
                },
                Source = new TransferSource
                {
                    Id = sourceId,
                    Type = "wallet",
                },
            };
            return await PostAsync<TransferInfo>($"{EndpointUrl}/transfers", data, cancellationToken);
        }

        public async Task<WebCallResult<TransferInfo>> GetTransferV2Async(string id,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<TransferInfo>($"{EndpointUrl}/transfers/{id}", cancellationToken);
        }

        public async Task<WebCallResult<TransferInfo[]>> GetTransfersV2Async(string pageAfter, int pageSize,
            CancellationToken cancellationToken = default)
        {
            var query = string.IsNullOrEmpty(pageAfter) ? "" : $"pageAfter={pageAfter}";
            return await GetAsync<TransferInfo[]>($"{EndpointUrl}/transfers?{query}&pageSize={pageSize}", cancellationToken);
        }
    }

    #endregion
}