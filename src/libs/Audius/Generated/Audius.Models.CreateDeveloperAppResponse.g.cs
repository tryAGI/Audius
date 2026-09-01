
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeveloperAppResponse
    {
        /// <summary>
        /// The API key (address) for the developer app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The private key for the developer app (for signing)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_secret")]
        public string? ApiSecret { get; set; }

        /// <summary>
        /// The bearer token for API authentication (use in Authorization header)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearer_token")]
        public string? BearerToken { get; set; }

        /// <summary>
        /// Transaction hash of the creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_hash")]
        public string? TransactionHash { get; set; }

        /// <summary>
        /// The blockchain block hash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_hash")]
        public string? BlockHash { get; set; }

        /// <summary>
        /// The blockchain block number/height
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_number")]
        public long? BlockNumber { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeveloperAppResponse" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The API key (address) for the developer app
        /// </param>
        /// <param name="apiSecret">
        /// The private key for the developer app (for signing)
        /// </param>
        /// <param name="bearerToken">
        /// The bearer token for API authentication (use in Authorization header)
        /// </param>
        /// <param name="transactionHash">
        /// Transaction hash of the creation
        /// </param>
        /// <param name="blockHash">
        /// The blockchain block hash
        /// </param>
        /// <param name="blockNumber">
        /// The blockchain block number/height
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeveloperAppResponse(
            string? apiKey,
            string? apiSecret,
            string? bearerToken,
            string? transactionHash,
            string? blockHash,
            long? blockNumber)
        {
            this.ApiKey = apiKey;
            this.ApiSecret = apiSecret;
            this.BearerToken = bearerToken;
            this.TransactionHash = transactionHash;
            this.BlockHash = blockHash;
            this.BlockNumber = blockNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeveloperAppResponse" /> class.
        /// </summary>
        public CreateDeveloperAppResponse()
        {
        }

    }
}