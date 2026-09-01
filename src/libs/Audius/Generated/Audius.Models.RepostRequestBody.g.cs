
#nullable enable

namespace Audius
{
    /// <summary>
    /// Optional metadata for repost operations
    /// </summary>
    public sealed partial class RepostRequestBody
    {
        /// <summary>
        /// Set to true when reposting an item that was reposted (used for notifications)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_repost_of_repost")]
        public bool? IsRepostOfRepost { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepostRequestBody" /> class.
        /// </summary>
        /// <param name="isRepostOfRepost">
        /// Set to true when reposting an item that was reposted (used for notifications)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepostRequestBody(
            bool? isRepostOfRepost)
        {
            this.IsRepostOfRepost = isRepostOfRepost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepostRequestBody" /> class.
        /// </summary>
        public RepostRequestBody()
        {
        }

    }
}