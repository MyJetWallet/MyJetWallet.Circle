using System.Threading;
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
        /// <param name="keyId">Unique identifier of the public key used in encryption.</param>
        /// <param name="email">Email of the user</param>
        /// <param name="phoneNumber">Phone number of the user in E.164 format. We recommend using a library such as libphonenumber to parse and validate phone numbers.</param>
        /// <param name="sessionId">Hash of the session identifier; typically of the end user. This helps us make risk decisions and prevent fraud. IMPORTANT: Please hash the session identifier to prevent sending us actual session identifiers.</param>
        /// <param name="ipAddress">Single IPv4 or IPv6 address of user</param>
        /// <param name="amount">Magnitude of the amount, in units of the currency, with a ..</param>
        /// <param name="currency">Currency code.</param>
        /// <param name="verification">Indicates the verification method for this payment. 3D Secure is currently limited to the Sandbox environment.</param>
        /// <param name="sourceId">Unique identifier for the source.</param>
        /// <param name="sourceType">Type of the source.</param>
        /// <param name="description">Description of the payment with length restriction of 240 characters.</param>
        /// /// <param name="encryptedData">PGP encrypted json string. The object format given here needs to be stringified and PGP encrypted before it is sent to the server, so encryptedData will end up as a string, rather than an object.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>

        public async Task<WebCallResult<PayoutInfo>> CreatePayout(
            string idempotencyKey, 
            string amount,
            string currency,
            string destinationId, 
            string destinationType,
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