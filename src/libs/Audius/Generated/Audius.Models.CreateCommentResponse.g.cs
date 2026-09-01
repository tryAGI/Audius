
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCommentResponse
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
        /// The ID of the created comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_id")]
        public string? CommentId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentResponse" /> class.
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
        /// <param name="commentId">
        /// The ID of the created comment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCommentResponse(
            string? transactionHash,
            string? blockHash,
            long? blockNumber,
            string? commentId)
        {
            this.TransactionHash = transactionHash;
            this.BlockHash = blockHash;
            this.BlockNumber = blockNumber;
            this.CommentId = commentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentResponse" /> class.
        /// </summary>
        public CreateCommentResponse()
        {
        }

    }
}