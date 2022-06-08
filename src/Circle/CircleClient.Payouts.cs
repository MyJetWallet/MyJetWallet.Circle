﻿using System.Threading;
using System.Threading.Tasks;
using MyJetWallet.Circle.Models;
using MyJetWallet.Circle.Models.Payouts;

namespace MyJetWallet.Circle
{
    public partial class CircleClient
    {
        #region Payouts

        /// <summary>
        /// Create a payment.
        /// </summary>
        /// <param name="idempotencyKey">Unique idempotency key. This key is utilized to ensure exactly-once execution of mutating requests.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>

        public async Task<WebCallResult<PayoutInfo>> CreatePayoutAsync(
            string idempotencyKey, 
            string amount,
            string currency,
            string destinationId, 
            string destinationType,
            string beneficiaryEmail,
            CancellationToken cancellationToken = default)
        {
            var data = new CreatePayoutRequest()
            {
                IdempotencyKey = idempotencyKey,
                Amount = new PayoutAmount
                {
                    Amount = amount,
                    Currency = currency
                },
                Destination = new PayoutDestination
                {
                    Id = destinationId,
                    Type = destinationType,
                },
                Metadata = new PayoutMetadata()
                {
                    BeneficiaryEmail = beneficiaryEmail,
                }
            };
            return await PostAsync<PayoutInfo>($"{EndpointUrl}/payouts", data, cancellationToken);
        }

        /// <summary>
        /// Get a payment.
        /// </summary>
        /// <param name="id">Unique identifier of the payment.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public WebCallResult<PayoutInfo> GetPayout(string id, CancellationToken cancellationToken = default) =>
            GetPayoutAsync(id, cancellationToken).Result;

        public async Task<WebCallResult<PayoutInfo>> GetPayoutAsync(string id,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<PayoutInfo>($"{EndpointUrl}/payouts/{id}", cancellationToken);
        }
    }

    #endregion
}