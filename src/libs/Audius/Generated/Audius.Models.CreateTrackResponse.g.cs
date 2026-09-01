
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTrackResponse
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
        /// The ID of the created track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        public string? TrackId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackResponse" /> class.
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
        /// <param name="trackId">
        /// The ID of the created track
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrackResponse(
            string? transactionHash,
            string? blockHash,
            long? blockNumber,
            string? trackId)
        {
            this.TransactionHash = transactionHash;
            this.BlockHash = blockHash;
            this.BlockNumber = blockNumber;
            this.TrackId = trackId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackResponse" /> class.
        /// </summary>
        public CreateTrackResponse()
        {
        }

    }
}