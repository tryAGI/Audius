
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Repost
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repost_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepostItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repost_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepostType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Repost" /> class.
        /// </summary>
        /// <param name="repostItemId"></param>
        /// <param name="repostType"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Repost(
            string repostItemId,
            string repostType,
            string userId)
        {
            this.RepostItemId = repostItemId ?? throw new global::System.ArgumentNullException(nameof(repostItemId));
            this.RepostType = repostType ?? throw new global::System.ArgumentNullException(nameof(repostType));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repost" /> class.
        /// </summary>
        public Repost()
        {
        }

    }
}