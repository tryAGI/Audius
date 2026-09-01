
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateUserResponse
    {
        /// <summary>
        /// The blockchain transaction hash
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
        /// The ID of the created user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserResponse" /> class.
        /// </summary>
        /// <param name="transactionHash">
        /// The blockchain transaction hash
        /// </param>
        /// <param name="blockHash">
        /// The blockchain block hash
        /// </param>
        /// <param name="blockNumber">
        /// The blockchain block number/height
        /// </param>
        /// <param name="userId">
        /// The ID of the created user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUserResponse(
            string? transactionHash,
            string? blockHash,
            long? blockNumber,
            string? userId)
        {
            this.TransactionHash = transactionHash;
            this.BlockHash = blockHash;
            this.BlockNumber = blockNumber;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserResponse" /> class.
        /// </summary>
        public CreateUserResponse()
        {
        }

    }
}