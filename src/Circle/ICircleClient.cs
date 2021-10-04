using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MyJetWallet.Circle.Models;
using MyJetWallet.Circle.Models.Cards;
using MyJetWallet.Circle.Models.Subscriptions;

namespace MyJetWallet.Circle
{
    public interface ICircleClient
    {
        #region PublicKey

        /// <summary>
        /// Retrieves an RSA public key to be used in encrypting data sent to the API. Your public keys change infrequently, so we encourage you to cache this response value locally for a duration of 24 hours or more.
        /// </summary>
        /// <returns>Public Key</returns>
        WebCallResult<PublicKey> GetPublicKey(CancellationToken cancellationToken = default);

        Task<WebCallResult<PublicKey>> GetPublicKeyAsync(
            CancellationToken cancellationToken = default);

        #endregion

        #region Cards

        /// <summary>
        /// Create a card.
        /// </summary>
        /// <param name="idempotencyKey">Unique idempotency key. This key is utilized to ensure exactly-once execution of mutating requests.</param>
        /// <param name="keyId">Unique identifier of the public key used in encryption.</param>
        /// <param name="encryptedData">PGP encrypted json string. The object format given here needs to be stringified and PGP encrypted before it is sent to the server, so encryptedData will end up as a string, rather than an object.</param>
        /// <param name="billingName">Full name of the card or bank account holder.</param>
        /// <param name="billingCity">City portion of the address.</param>
        /// <param name="billingCountry">Country portion of the address. Formatted as a two-letter country code specified in ISO 3166-1 alpha-2.</param>
        /// <param name="billingLine1">Line one of the street address.</param>
        /// <param name="billingLine2">Line two of the street address.</param>
        /// <param name="billingDistrict">State / County / Province / Region portion of the address. If the country is US or Canada district is required and should use the two-letter code for the subdivision.</param>
        /// <param name="billingPostalCode">Postal / ZIP code of the address.</param>
        /// <param name="expMonth">Two digit number representing the card's expiration month.</param>
        /// <param name="expYear">Four digit number representing the card's expiration year.</param>
        /// <param name="email">Email of the user</param>
        /// <param name="phoneNumber">Phone number of the user in E.164 format. We recommend using a library such as libphonenumber to parse and validate phone numbers.</param>
        /// <param name="sessionId">Hash of the session identifier; typically of the end user. This helps us make risk decisions and prevent fraud. IMPORTANT: Please hash the session identifier to prevent sending us actual session identifiers.</param>
        /// <param name="ipAddress">Single IPv4 or IPv6 address of user</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        WebCallResult<CardInfo> CreateCard(
            string idempotencyKey,
            string keyId,
            string encryptedData,
            string billingName,
            string billingCity,
            string billingCountry,
            string billingLine1,
            string billingLine2,
            string billingDistrict,
            string billingPostalCode,
            int expMonth,
            int expYear,
            string email,
            string phoneNumber,
            string sessionId,
            string ipAddress,
            CancellationToken cancellationToken = default);

        Task<WebCallResult<CardInfo>> CreateCardAsync(
            string idempotencyKey,
            string keyId,
            string encryptedData,
            string billingName,
            string billingCity,
            string billingCountry,
            string billingLine1,
            string billingLine2,
            string billingDistrict,
            string billingPostalCode,
            int expMonth,
            int expYear,
            string email,
            string phoneNumber,
            string sessionId,
            string ipAddress,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// List receive addresses on a wallet
        /// </summary>
        /// <param name="pageBefore">It marks the exclusive end of a page. When provided, the collection resource will return the next n items before the id, with n being specified by pageSize.</param>
        /// <param name="pageAfter">It marks the exclusive begin of a page. When provided, the collection resource will return the next n items after the id, with n being specified by pageSize.</param>
        /// <param name="pageSize">Limits the number of items to be returned.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        WebCallResult<List<CardInfo>> GetListOfCards(
            string pageBefore = null,
            string pageAfter = null,
            int pageSize = 50,
            CancellationToken cancellationToken = default);

        Task<WebCallResult<List<CardInfo>>> GetListOfCardsAsync(
            string pageBefore = null,
            string pageAfter = null,
            int pageSize = 50,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a card.
        /// </summary>
        /// <param name="id">Unique identifier of the card.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        WebCallResult<CardInfo> GetCard(
            string id,
            CancellationToken cancellationToken = default);

        Task<WebCallResult<CardInfo>> GetCardAsync(
            string id,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a card.
        /// </summary>
        /// <param name="id">Unique identifier of the card.</param>
        /// <param name="keyId">Unique identifier of the public key used in encryption.</param>
        /// <param name="encryptedData">PGP encrypted json string. The object format given here needs to be stringified and PGP encrypted before it is sent to the server, so encryptedData will end up as a string, rather than an object.</param>
        /// <param name="expMonth">Two digit number representing the card's expiration month.</param>
        /// <param name="expYear">Four digit number representing the card's expiration year.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        WebCallResult<CardInfo> UpdateCard(
            string id,
            string keyId,
            string encryptedData,
            int expMonth,
            int expYear,
            CancellationToken cancellationToken = default);

        Task<WebCallResult<CardInfo>> UpdateCardAsync(
            string id,
            string keyId,
            string encryptedData,
            int expMonth,
            int expYear,
            CancellationToken cancellationToken = default);

        #endregion

        #region Subscriptions

        /// <summary>
        /// Get a list of notification subscriptions.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        WebCallResult<List<Subscription>> GetListOfSubscriptions(
            CancellationToken cancellationToken = default);

        Task<WebCallResult<List<Subscription>>> GetListOfSubscriptionsAsync(
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Subscribe to receiving notifications at a given endpoint. The endpoint should be able to handle AWS SNS subscription requests. For more details see https://docs.aws.amazon.com/mobile/sdkforxamarin/developerguide/sns-send-http.html.
        /// Note, the sandbox environment allows a maximum of 3 active subscriptions; otherwise, this is limited to 1 active subscription and subsequent create requests will be rejected with a Limit Exceeded error.
        /// </summary>
        /// <param name="endpoint">URL of the subscriber endpoint. Must be publicly accessible and utilize HTTPS.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        WebCallResult<Subscription> CreateSubscription(
            string endpoint,
            CancellationToken cancellationToken = default);

        Task<WebCallResult<Subscription>> CreateSubscriptionAsync(
            string endpoint,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// To remove a subscription, all its subscription requests' statuses must be either 'confirmed', 'deleted' or a combination of those. A subscription with at least one 'pending' subscription request cannot be removed.
        /// </summary>
        /// <param name="id">Unique identifier for the subscription.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        WebCallResult<string> RemoveSubscription(
            string id,
            CancellationToken cancellationToken = default);

        Task<WebCallResult<string>> RemoveSubscriptionAsync(
            string id,
            CancellationToken cancellationToken = default);

        #endregion
    }
}