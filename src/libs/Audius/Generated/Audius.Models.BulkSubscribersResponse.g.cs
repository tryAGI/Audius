
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkSubscribersResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_chain_block")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestChainBlock { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_indexed_block")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestIndexedBlock { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_chain_slot_plays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestChainSlotPlays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_indexed_slot_plays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestIndexedSlotPlays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.VersionMetadata Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Audius.UserSubscribers>? Data { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSubscribersResponse" /> class.
        /// </summary>
        /// <param name="latestChainBlock"></param>
        /// <param name="latestIndexedBlock"></param>
        /// <param name="latestChainSlotPlays"></param>
        /// <param name="latestIndexedSlotPlays"></param>
        /// <param name="signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="version"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkSubscribersResponse(
            int latestChainBlock,
            int latestIndexedBlock,
            int latestChainSlotPlays,
            int latestIndexedSlotPlays,
            string signature,
            string timestamp,
            global::Audius.VersionMetadata version,
            global::System.Collections.Generic.IList<global::Audius.UserSubscribers>? data)
        {
            this.LatestChainBlock = latestChainBlock;
            this.LatestIndexedBlock = latestIndexedBlock;
            this.LatestChainSlotPlays = latestChainSlotPlays;
            this.LatestIndexedSlotPlays = latestIndexedSlotPlays;
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSubscribersResponse" /> class.
        /// </summary>
        public BulkSubscribersResponse()
        {
        }

    }
}